namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label_depositPrompt;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Button button_deposit;
        private System.Windows.Forms.Label label_balance;
        private System.Windows.Forms.Label label_lastWin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_betPrompt;
        private System.Windows.Forms.ComboBox comboBoxBet;
        private System.Windows.Forms.Label label_totalSpins;
        private System.Windows.Forms.Label lblWinlabel_winCount;
        private System.Windows.Forms.Label label_winRate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            this.label_depositPrompt = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.button_deposit = new System.Windows.Forms.Button();
            this.label_balance = new System.Windows.Forms.Label();
            this.label_lastWin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_betPrompt = new System.Windows.Forms.Label();
            this.comboBoxBet = new System.Windows.Forms.ComboBox();
            this.label_totalSpins = new System.Windows.Forms.Label();
            this.lblWinlabel_winCount = new System.Windows.Forms.Label();
            this.label_winRate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label_depositPrompt
            // 
            this.label_depositPrompt.AutoSize = true;
            this.label_depositPrompt.Location = new System.Drawing.Point(24, 12);
            this.label_depositPrompt.Name = "label_depositPrompt";
            this.label_depositPrompt.Size = new System.Drawing.Size(230, 45);
            this.label_depositPrompt.TabIndex = 0;
            this.label_depositPrompt.Text = "存入金額： $";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(210, 8);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(200, 55);
            this.txtDeposit.TabIndex = 1;
            // 
            // button_deposit
            // 
            this.button_deposit.Location = new System.Drawing.Point(464, 8);
            this.button_deposit.Name = "button_deposit";
            this.button_deposit.Size = new System.Drawing.Size(186, 49);
            this.button_deposit.TabIndex = 2;
            this.button_deposit.Text = "存入";
            this.button_deposit.UseVisualStyleBackColor = true;
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.Location = new System.Drawing.Point(24, 60);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(320, 45);
            this.label_balance.TabIndex = 3;
            this.label_balance.Text = "餘額： NT$000.00";
            this.label_balance.Click += new System.EventHandler(this.label_balance_Click);
            // 
            // label_lastWin
            // 
            this.label_lastWin.AutoSize = true;
            this.label_lastWin.Location = new System.Drawing.Point(300, 60);
            this.label_lastWin.Name = "label_lastWin";
            this.label_lastWin.Size = new System.Drawing.Size(350, 45);
            this.label_lastWin.TabIndex = 4;
            this.label_lastWin.Text = "本次獲得： NT$0.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightYellow;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(81, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightYellow;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(283, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightYellow;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(479, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label_betPrompt
            // 
            this.label_betPrompt.AutoSize = true;
            this.label_betPrompt.Location = new System.Drawing.Point(83, 244);
            this.label_betPrompt.Name = "label_betPrompt";
            this.label_betPrompt.Size = new System.Drawing.Size(200, 45);
            this.label_betPrompt.TabIndex = 8;
            this.label_betPrompt.Text = "下注金額：";
            // 
            // comboBoxBet
            // 
            this.comboBoxBet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBet.FormattingEnabled = true;
            this.comboBoxBet.Items.AddRange(new object[] {
            "$1",
            "$5",
            "$10",
            "$50"});
            this.comboBoxBet.Location = new System.Drawing.Point(283, 244);
            this.comboBoxBet.Name = "comboBoxBet";
            this.comboBoxBet.Size = new System.Drawing.Size(140, 53);
            this.comboBoxBet.TabIndex = 9;
            // 
            // label_totalSpins
            // 
            this.label_totalSpins.AutoSize = true;
            this.label_totalSpins.Location = new System.Drawing.Point(36, 300);
            this.label_totalSpins.Name = "label_totalSpins";
            this.label_totalSpins.Size = new System.Drawing.Size(203, 45);
            this.label_totalSpins.TabIndex = 10;
            this.label_totalSpins.Text = "旋轉： 0 次";
            // 
            // lblWinlabel_winCount
            // 
            this.lblWinlabel_winCount.AutoSize = true;
            this.lblWinlabel_winCount.Location = new System.Drawing.Point(245, 300);
            this.lblWinlabel_winCount.Name = "lblWinlabel_winCount";
            this.lblWinlabel_winCount.Size = new System.Drawing.Size(203, 45);
            this.lblWinlabel_winCount.TabIndex = 11;
            this.lblWinlabel_winCount.Text = "中獎： 0 次";
            // 
            // label_winRate
            // 
            this.label_winRate.AutoSize = true;
            this.label_winRate.Location = new System.Drawing.Point(454, 300);
            this.label_winRate.Name = "label_winRate";
            this.label_winRate.Size = new System.Drawing.Size(219, 45);
            this.label_winRate.TabIndex = 12;
            this.label_winRate.Text = "勝率： 0.0%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "旋轉";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 56);
            this.button2.TabIndex = 14;
            this.button2.Text = "離開";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Apple.bmp");
            this.imageList1.Images.SetKeyName(1, "Banana.bmp");
            this.imageList1.Images.SetKeyName(2, "Cherries.bmp");
            this.imageList1.Images.SetKeyName(3, "Grapes.bmp");
            this.imageList1.Images.SetKeyName(4, "Lemon.bmp");
            this.imageList1.Images.SetKeyName(5, "Lime.bmp");
            this.imageList1.Images.SetKeyName(6, "Orange.bmp");
            this.imageList1.Images.SetKeyName(7, "Pear.bmp");
            this.imageList1.Images.SetKeyName(8, "Strawberry.bmp");
            this.imageList1.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(723, 455);
            this.Controls.Add(this.label_depositPrompt);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.button_deposit);
            this.Controls.Add(this.label_balance);
            this.Controls.Add(this.label_lastWin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label_betPrompt);
            this.Controls.Add(this.comboBoxBet);
            this.Controls.Add(this.label_totalSpins);
            this.Controls.Add(this.lblWinlabel_winCount);
            this.Controls.Add(this.label_winRate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "吃角子老虎機";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
    }
}

