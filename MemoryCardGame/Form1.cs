using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryCardGame
{
    public partial class Form1 : Form
    {
        public class Card
        {
            private static Random rnd = new Random();
            private int [] Img;

            public Card(int have)
            {
                Img  = new int[have*2];
                int runNum = 0; //開始分牌(11223344)
                for(int i = 1; i <= have; i++) {
                    for(int j = 0; j < 2; j++) {
                        Img[runNum++] = i;
                    }
                }
                //洗牌交換
                for(int i = 0; i < have*2; i++) {
                    int catchNum = rnd.Next(have) + 1;//從所有牌挑
                    int tmp = Img[i];
                    Img[i] = Img[catchNum];
                    Img[catchNum] = tmp;
                }
            }

            public int getCurrent(int i)
            {
                return Img[i];
            }

        }

        const int haveImg = 8;
        int countTime = 0; //計時器時間
        int gameTime = 0; //遊戲時間
        int clickCount = 0;//翻牌次數
        int rem_preImg = 0;//記住上一次的解答圖片
        int rem_preCard = 0;//記住上一次的按下牌位置
        int rem_Card = 0;//記住按下牌位置(錯誤牌用)

        double secondRate = 0.0; //每秒平均單量
        Boolean startClick = false;
        Card Imgbox ;//卡牌
        Label [] ImgArea = new Label[haveImg*2]; //存Label
        System.Media.SoundPlayer sndPlayer;

        public Form1()
        {
            InitializeComponent();

            //把Label集合到陣列裡
            int setImg = 0;
            foreach (Control img in tableLayoutPanel1.Controls) {
                if (img is Label) {
                    ImgArea[setImg] = (Label)img;
                    setImg++;
                }
            }
        }

        public static bool IsNumeric(string TextBoxValue)
         {
              try
             {
                  int i = Convert.ToInt32(TextBoxValue);
                   return true ;
              }
             catch
             {
                  return false ;
              }
          }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (IsNumeric(timeBox.Text)) {
                gameTime = int.Parse(timeBox.Text);
                if(gameTime>0 && gameTime <= 10000) {
                    //保證時間格式無誤才開始
                    buttonStart.Enabled = false;
                    Imgbox = new Card(haveImg); //洗牌
                    for (int i = 0; i < ImgArea.Length; i++) {
                        ImgArea[i].ImageIndex = Imgbox.getCurrent(i); //開始抽自己的位置
                    }
                    //開始計時動作，遊戲開始
                    countTime = 0;
                    clickCount = 0;
                    TimeProgress.Value = 0;
                    timer1.Enabled = true;
                    recTime.Text = Convert.ToString(gameTime + " s");

                }
               
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countTime++;
            if (countTime < 5) {
                TimeProgress.Value += 25; //5秒記憶時間
            } else if (countTime == 5) {
                for (int i = 0; i < ImgArea.Length; i++) {
                    ImgArea[i].ImageIndex = 0; //蓋牌
                }
                startClick = true;
                secondRate = 100 / (double)gameTime;
            } else if (gameTime == 0) {
                sndPlayer = new System.Media.SoundPlayer(Application.StartupPath + @"/loss.wav");
                sndPlayer.Play();
                timer1.Enabled = false; //time's up!
                recTime.Text = "Time's up!";
                pre_time.Text = "失敗";
                startClick = false;
                buttonStart.Enabled = true;
            } else { 
                gameTime--; //倒數
                recTime.Text = Convert.ToString(gameTime + " s");
                TimeProgress.Value = Convert.ToInt32(gameTime * secondRate);
            }
        }

        private Boolean findDone()
        { //用來檢查是否都完成
            Boolean find = true;
            for (int i = 0; i < ImgArea.Length; i++) {
                if (ImgArea[i].ImageIndex == 0) {
                    find = false;
                    break;
                }
            }
            return find;
        }
        private void judgmentClick(object sender, MouseEventArgs e)
        {
            if (startClick) {
                
                Label clickImg = (Label)sender;
                for (int i = 0; i < ImgArea.Length; i++) {
                    if (Object.ReferenceEquals(ImgArea[i], clickImg)) {
                        
                        //需要檢查是否為已翻開，避免錯誤
                        if (ImgArea[i].ImageIndex == 0) {
                            clickCount++;
                            click_count.Text = Convert.ToString(clickCount);
                            if (clickCount % 2 == 1) {
                                ImgArea[i].ImageIndex = Imgbox.getCurrent(i);
                                rem_preImg = Imgbox.getCurrent(i); //開始記牌
                                rem_preCard = i;
                            } else {
                                if(Imgbox.getCurrent(i)== rem_preImg) {
                                    sndPlayer = new System.Media.SoundPlayer(Application.StartupPath + @"/correct.wav");
                                    sndPlayer.Play();
                                    ImgArea[i].ImageIndex = Imgbox.getCurrent(i);
                                    if (findDone()) {
                                        sndPlayer = new System.Media.SoundPlayer(Application.StartupPath + @"/win.wav");
                                        sndPlayer.Play();
                                        timer1.Enabled = false;
                                        pre_time.Text = Convert.ToString(countTime - 5)+" s";//前次花費時間
                                        startClick = false;
                                        buttonStart.Enabled = true;
                                    }
                                } else {
                                    sndPlayer = new System.Media.SoundPlayer(Application.StartupPath + @"/error.wav");
                                    sndPlayer.Play();
                                    startClick = false;
                                    ImgArea[i].ImageIndex = Imgbox.getCurrent(i);
                                    rem_Card = i;
                                    timer2.Enabled = true; //按錯鎖住不給按
                                }
                            }
                        }

                        break;
                    }
                }

            }


        }


        private void errorShow(object sender, EventArgs e)
        {
                ImgArea[rem_preCard].ImageIndex = 0;
                ImgArea[rem_Card].ImageIndex = 0;
                timer2.Enabled = false;
            startClick = true; 
        }
    }
}
