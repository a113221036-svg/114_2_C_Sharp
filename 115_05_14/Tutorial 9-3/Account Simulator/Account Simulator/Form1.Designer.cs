namespace Account_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.depositGroupBox = new System.Windows.Forms.GroupBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.depositAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.withdrawTextBox = new System.Windows.Forms.TextBox();
            this.withdrawAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.balanceDescriptionLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.depositGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // depositGroupBox - 存款群組
            // 
            this.depositGroupBox.Controls.Add(this.depositButton);
            this.depositGroupBox.Controls.Add(this.depositTextBox);
            this.depositGroupBox.Controls.Add(this.depositAmountDescriptionLabel);
            this.depositGroupBox.Location = new System.Drawing.Point(12, 80);
            this.depositGroupBox.Name = "depositGroupBox";
            this.depositGroupBox.Size = new System.Drawing.Size(220, 120);
            this.depositGroupBox.TabIndex = 0;
            this.depositGroupBox.TabStop = false;
            this.depositGroupBox.Text = "進行存款";
            this.depositGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            // 
            // depositButton - 存款按鈕
            // 
            this.depositButton.Location = new System.Drawing.Point(50, 70);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(120, 40);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "存款";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // depositTextBox - 存款金額輸入框
            // 
            this.depositTextBox.Location = new System.Drawing.Point(100, 25);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(100, 35);
            this.depositTextBox.TabIndex = 1;
            this.depositTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            // 
            // depositAmountDescriptionLabel - 存款金額標籤
            // 
            this.depositAmountDescriptionLabel.AutoSize = true;
            this.depositAmountDescriptionLabel.Location = new System.Drawing.Point(10, 30);
            this.depositAmountDescriptionLabel.Name = "depositAmountDescriptionLabel";
            this.depositAmountDescriptionLabel.Size = new System.Drawing.Size(80, 35);
            this.depositAmountDescriptionLabel.TabIndex = 0;
            this.depositAmountDescriptionLabel.Text = "金額:";
            this.depositAmountDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            // 
            // groupBox1 - 提款群組
            // 
            this.groupBox1.Controls.Add(this.withdrawButton);
            this.groupBox1.Controls.Add(this.withdrawTextBox);
            this.groupBox1.Controls.Add(this.withdrawAmountDescriptionLabel);
            this.groupBox1.Location = new System.Drawing.Point(250, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "進行提款";
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            // 
            // withdrawButton - 提款按鈕
            // 
            this.withdrawButton.Location = new System.Drawing.Point(50, 70);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(120, 40);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "提款";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // withdrawTextBox - 提款金額輸入框
            // 
            this.withdrawTextBox.Location = new System.Drawing.Point(100, 25);
            this.withdrawTextBox.Name = "withdrawTextBox";
            this.withdrawTextBox.Size = new System.Drawing.Size(100, 35);
            this.withdrawTextBox.TabIndex = 1;
            this.withdrawTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            // 
            // withdrawAmountDescriptionLabel - 提款金額標籤
            // 
            this.withdrawAmountDescriptionLabel.AutoSize = true;
            this.withdrawAmountDescriptionLabel.Location = new System.Drawing.Point(10, 30);
            this.withdrawAmountDescriptionLabel.Name = "withdrawAmountDescriptionLabel";
            this.withdrawAmountDescriptionLabel.Size = new System.Drawing.Size(80, 35);
            this.withdrawAmountDescriptionLabel.TabIndex = 0;
            this.withdrawAmountDescriptionLabel.Text = "金額:";
            this.withdrawAmountDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            // 
            // balanceDescriptionLabel - 餘額說明標籤
            // 
            this.balanceDescriptionLabel.AutoSize = true;
            this.balanceDescriptionLabel.Location = new System.Drawing.Point(80, 25);
            this.balanceDescriptionLabel.Name = "balanceDescriptionLabel";
            this.balanceDescriptionLabel.Size = new System.Drawing.Size(100, 35);
            this.balanceDescriptionLabel.TabIndex = 2;
            this.balanceDescriptionLabel.Text = "帳戶餘額:";
            this.balanceDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            // 
            // balanceLabel - 餘額顯示標籤
            // 
            this.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel.Location = new System.Drawing.Point(200, 20);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(150, 45);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            // 
            // exitButton - 結束按鈕
            // 
            this.exitButton.Location = new System.Drawing.Point(200, 220);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 50);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1 - 帳戶模擬器應用程式主視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.balanceDescriptionLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.depositGroupBox);
            this.Name = "Form1";
            this.Text = "帳戶模擬器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.depositGroupBox.ResumeLayout(false);
            this.depositGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox depositGroupBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.Label depositAmountDescriptionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.TextBox withdrawTextBox;
        private System.Windows.Forms.Label withdrawAmountDescriptionLabel;
        private System.Windows.Forms.Label balanceDescriptionLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

