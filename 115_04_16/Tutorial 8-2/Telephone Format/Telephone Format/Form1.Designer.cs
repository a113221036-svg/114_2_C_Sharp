namespace Telephone_Format
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.formatButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 註解（下列為元件字型與大小統一設定）
            // 所有元件的字型設定為「Microsoft JhengHei」，字型大小 18pt，
            // 以確保繁體中文顯示清晰，並符合專案需求。
            // 
            // numberTextBox
            // 
            // 註解：輸入欄位，用戶在此輸入 10 位電話號碼（僅接受數字）
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numberTextBox.Location = new System.Drawing.Point(52, 80);
            this.numberTextBox.Name = "numberTextBox";
            // 調整寬度以容納較大字型，並增加高度以符合字型大小
            this.numberTextBox.Size = new System.Drawing.Size(300, 40);
            this.numberTextBox.TabIndex = 0;
            // 
            // instructionLabel
            // 
            // 註解：說明文字，提示使用者輸入格式與意圖
            this.instructionLabel.AutoSize = false;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.instructionLabel.Location = new System.Drawing.Point(12, 12);
            this.instructionLabel.Name = "instructionLabel";
            // 增大說明欄位高度以避免文字換行擁擠
            this.instructionLabel.Size = new System.Drawing.Size(380, 60);
            this.instructionLabel.TabIndex = 1;
            // 將說明文字改為繁體中文
            this.instructionLabel.Text = "請輸入 10 位數字，我會將它格式化為電話號碼。";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formatButton
            // 
            // 註解：按下後呼叫格式化事件，會將輸入轉換成電話格式並顯示
            this.formatButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 將按鈕放置在輸入欄下方靠左的位置，並放大按鈕以符合 18pt 字型
            this.formatButton.Location = new System.Drawing.Point(52, 135);
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(140, 50);
            this.formatButton.TabIndex = 2;
            // 將按鈕文字改為繁體中文
            this.formatButton.Text = "格式化";
            this.formatButton.UseVisualStyleBackColor = true;
            this.formatButton.Click += new System.EventHandler(this.formatButton_Click);
            // 
            // exitButton
            // 
            // 註解：離開按鈕，關閉視窗
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 將按鈕放置在輸入欄下方靠右的位置，並放大按鈕以符合 18pt 字型
            this.exitButton.Location = new System.Drawing.Point(212, 135);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 50);
            this.exitButton.TabIndex = 3;
            // 將按鈕文字改為繁體中文
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 註解：調整表單大小以容納放大的元件與間距
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 設定表單整體大小以容納所有元件
            this.ClientSize = new System.Drawing.Size(404, 205);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.formatButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.numberTextBox);
            this.Name = "Form1";
            // 將表單標題改為繁體中文
            this.Text = "電話號碼格式化";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button formatButton;
        private System.Windows.Forms.Button exitButton;
    }
}

