namespace MemoryCardGame
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.click_count = new System.Windows.Forms.Label();
            this.pre_time = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.recTime = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TimeProgress = new System.Windows.Forms.ProgressBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timeBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // click_count
            // 
            this.click_count.AutoSize = true;
            this.click_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click_count.Location = new System.Drawing.Point(671, 64);
            this.click_count.Name = "click_count";
            this.click_count.Size = new System.Drawing.Size(89, 29);
            this.click_count.TabIndex = 13;
            this.click_count.Text = "Not set";
            // 
            // pre_time
            // 
            this.pre_time.AutoSize = true;
            this.pre_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre_time.Location = new System.Drawing.Point(671, 26);
            this.pre_time.Name = "pre_time";
            this.pre_time.Size = new System.Drawing.Size(89, 29);
            this.pre_time.TabIndex = 12;
            this.pre_time.Text = "Not set";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(550, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 30);
            this.label17.TabIndex = 11;
            this.label17.Text = "前次時間:";
            // 
            // recTime
            // 
            this.recTime.AutoSize = true;
            this.recTime.Font = new System.Drawing.Font("Tekton Pro Ext", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recTime.Location = new System.Drawing.Point(235, 49);
            this.recTime.Name = "recTime";
            this.recTime.Size = new System.Drawing.Size(84, 34);
            this.recTime.TabIndex = 10;
            this.recTime.Text = "time";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(550, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 30);
            this.label18.TabIndex = 9;
            this.label18.Text = "翻牌次數:";
            // 
            // TimeProgress
            // 
            this.TimeProgress.Location = new System.Drawing.Point(43, 39);
            this.TimeProgress.Name = "TimeProgress";
            this.TimeProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeProgress.Size = new System.Drawing.Size(471, 54);
            this.TimeProgress.Step = 1;
            this.TimeProgress.TabIndex = 8;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Fold.png");
            this.imageList1.Images.SetKeyName(1, "CaptainAmerica.png");
            this.imageList1.Images.SetKeyName(2, "Deadpool.png");
            this.imageList1.Images.SetKeyName(3, "Hawkeye.png");
            this.imageList1.Images.SetKeyName(4, "Hulk.png");
            this.imageList1.Images.SetKeyName(5, "IronMan.png");
            this.imageList1.Images.SetKeyName(6, "S.H.I.E.L.D.png");
            this.imageList1.Images.SetKeyName(7, "SpyderMan.png");
            this.imageList1.Images.SetKeyName(8, "Thor.png");
            // 
            // timeBox
            // 
            this.timeBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.timeBox.Font = new System.Drawing.Font("Square721 BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBox.Location = new System.Drawing.Point(100, 858);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(95, 32);
            this.timeBox.TabIndex = 17;
            this.timeBox.Text = "60";
            this.timeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label22.Location = new System.Drawing.Point(95, 827);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(124, 28);
            this.label22.TabIndex = 16;
            this.label22.Text = "遊戲時間(s)";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonStart.Location = new System.Drawing.Point(326, 827);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(377, 63);
            this.buttonStart.TabIndex = 15;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(100, 891);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 29);
            this.label23.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label16, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(46, 128);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.48544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.51456F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(691, 666);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.ImageIndex = 0;
            this.label16.ImageList = this.imageList1;
            this.label16.Location = new System.Drawing.Point(519, 490);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 168);
            this.label16.TabIndex = 15;
            this.label16.MouseClick += new System.Windows.Forms.MouseEventHandler(this.judgmentClick);
            // 
            // label15
            // 
            this.label15.ImageIndex = 0;
            this.label15.ImageList = this.imageList1;
            this.label15.Location = new System.Drawing.Point(348, 490);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(165, 168);
            this.label15.TabIndex = 14;
            this.label15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.judgmentClick);
            // 
            // label14
            // 
            this.label14.ImageIndex = 0;
            this.label14.ImageList = this.imageList1;
            this.label14.Location = new System.Drawing.Point(177, 490);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 168);
            this.label14.TabIndex = 13;
            this.label14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.judgmentClick);
            // 
            // label13
            // 
            this.label13.ImageIndex = 0;
            this.label13.ImageList = this.imageList1;
            this.label13.Location = new System.Drawing.Point(6, 490);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 168);
            this.label13.TabIndex = 12;
            this.label13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.judgmentClick);
            // 
            // label12
            // 
            this.label12.ImageIndex = 0;
            this.label12.ImageList = this.imageList1;
            this.label12.Location = new System.Drawing.Point(519, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 160);
            this.label12.TabIndex = 11;
            this.label12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.judgmentClick);
            // 
            // label11
            // 
            this.label11.ImageIndex = 0;
            this.label11.ImageList = this.imageList1;
            this.label11.Location = new System.Drawing.Point(348, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 160);
            this.label11.TabIndex = 10;
            this.label11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.judgmentClick);
            // 
            // label10
            // 
            this.label10.ImageIndex = 0;
            this.label10.ImageList = this.imageList1;
            this.label10.Location = new System.Drawing.Point(177, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 160);
            this.label10.TabIndex = 9;
            this.label10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.judgmentClick);
            // 
            // label9
            // 
            this.label9.ImageIndex = 0;
            this.label9.ImageList = this.imageList1;
            this.label9.Location = new System.Drawing.Point(6, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 160);
            this.label9.TabIndex = 8;
            this.label9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.judgmentClick);
            // 
            // label7
            // 
            this.label7.ImageIndex = 0;
            this.label7.ImageList = this.imageList1;
            this.label7.Location = new System.Drawing.Point(348, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 160);
            this.label7.TabIndex = 6;
            this.label7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.judgmentClick);
            // 
            // label6
            // 
            this.label6.ImageIndex = 0;
            this.label6.ImageList = this.imageList1;
            this.label6.Location = new System.Drawing.Point(177, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 160);
            this.label6.TabIndex = 5;
            this.label6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.judgmentClick);
            // 
            // label5
            // 
            this.label5.ImageIndex = 0;
            this.label5.ImageList = this.imageList1;
            this.label5.Location = new System.Drawing.Point(6, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 160);
            this.label5.TabIndex = 4;
            this.label5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.judgmentClick);
            // 
            // label4
            // 
            this.label4.ImageIndex = 0;
            this.label4.ImageList = this.imageList1;
            this.label4.Location = new System.Drawing.Point(519, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 163);
            this.label4.TabIndex = 3;
            this.label4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.judgmentClick);
            // 
            // label3
            // 
            this.label3.ImageIndex = 0;
            this.label3.ImageList = this.imageList1;
            this.label3.Location = new System.Drawing.Point(348, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 163);
            this.label3.TabIndex = 2;
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.judgmentClick);
            // 
            // label2
            // 
            this.label2.ImageIndex = 0;
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(177, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 163);
            this.label2.TabIndex = 1;
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.judgmentClick);
            // 
            // label1
            // 
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 156);
            this.label1.TabIndex = 0;
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.judgmentClick);
            // 
            // label8
            // 
            this.label8.ImageIndex = 0;
            this.label8.ImageList = this.imageList1;
            this.label8.Location = new System.Drawing.Point(519, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 160);
            this.label8.TabIndex = 7;
            this.label8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.judgmentClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 700;
            this.timer2.Tick += new System.EventHandler(this.errorShow);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(782, 923);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.click_count);
            this.Controls.Add(this.pre_time);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.recTime);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TimeProgress);
            this.Name = "Form1";
            this.Text = "記憶翻牌遊戲";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label click_count;
        private System.Windows.Forms.Label pre_time;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label recTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ProgressBar TimeProgress;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

