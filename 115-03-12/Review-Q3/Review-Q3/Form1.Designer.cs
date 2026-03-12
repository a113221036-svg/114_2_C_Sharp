namespace Review_Q3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Label lblNum4;
        private System.Windows.Forms.Label lblNum5;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label lblCompareTitle;
        private System.Windows.Forms.Label lblMatchCount;
        private System.Windows.Forms.Label lblMatchedNumbers;
        private System.Windows.Forms.ListBox lstDrawn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblNum3 = new Label();
            lblNum4 = new Label();
            lblNum5 = new Label();
            btnGenerate = new Button();
            btnDraw = new Button();
            btnExit = new Button();
            txtResults = new TextBox();
            lblCompareTitle = new Label();
            lblMatchCount = new Label();
            lblMatchedNumbers = new Label();
            lstDrawn = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.BorderStyle = BorderStyle.FixedSingle;
            lblNum1.Font = new Font("Segoe UI", 18F);
            lblNum1.Location = new Point(36, 27);
            lblNum1.Margin = new Padding(4, 0, 4, 0);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(119, 89);
            lblNum1.TabIndex = 0;
            lblNum1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNum2
            // 
            lblNum2.BorderStyle = BorderStyle.FixedSingle;
            lblNum2.Font = new Font("Segoe UI", 18F);
            lblNum2.Location = new Point(180, 27);
            lblNum2.Margin = new Padding(4, 0, 4, 0);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(119, 89);
            lblNum2.TabIndex = 1;
            lblNum2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNum3
            // 
            lblNum3.BorderStyle = BorderStyle.FixedSingle;
            lblNum3.Font = new Font("Segoe UI", 18F);
            lblNum3.Location = new Point(324, 27);
            lblNum3.Margin = new Padding(4, 0, 4, 0);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(119, 89);
            lblNum3.TabIndex = 2;
            lblNum3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNum4
            // 
            lblNum4.BorderStyle = BorderStyle.FixedSingle;
            lblNum4.Font = new Font("Segoe UI", 18F);
            lblNum4.Location = new Point(468, 27);
            lblNum4.Margin = new Padding(4, 0, 4, 0);
            lblNum4.Name = "lblNum4";
            lblNum4.Size = new Size(119, 89);
            lblNum4.TabIndex = 3;
            lblNum4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNum5
            // 
            lblNum5.BorderStyle = BorderStyle.FixedSingle;
            lblNum5.Font = new Font("Segoe UI", 18F);
            lblNum5.Location = new Point(612, 27);
            lblNum5.Margin = new Padding(4, 0, 4, 0);
            lblNum5.Name = "lblNum5";
            lblNum5.Size = new Size(119, 89);
            lblNum5.TabIndex = 4;
            lblNum5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI", 18F);
            btnGenerate.Location = new Point(36, 132);
            btnGenerate.Margin = new Padding(4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(240, 84);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "產生號碼";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnDraw
            // 
            btnDraw.Font = new Font("Segoe UI", 18F);
            btnDraw.Location = new Point(300, 132);
            btnDraw.Margin = new Padding(4);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(240, 84);
            btnDraw.TabIndex = 6;
            btnDraw.Text = "開獎號碼";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 18F);
            btnExit.Location = new Point(564, 132);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(168, 84);
            btnExit.TabIndex = 7;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtResults
            // 
            txtResults.Font = new Font("Segoe UI", 14F);
            txtResults.Location = new Point(390, 237);
            txtResults.Margin = new Padding(4);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.ScrollBars = ScrollBars.Vertical;
            txtResults.Size = new Size(328, 266);
            txtResults.TabIndex = 9;
            // 
            // lblCompareTitle
            // 
            lblCompareTitle.Font = new Font("Segoe UI", 18F);
            lblCompareTitle.ForeColor = Color.Red;
            lblCompareTitle.Location = new Point(756, 237);
            lblCompareTitle.Margin = new Padding(4, 0, 4, 0);
            lblCompareTitle.Name = "lblCompareTitle";
            lblCompareTitle.Size = new Size(360, 54);
            lblCompareTitle.TabIndex = 10;
            lblCompareTitle.Text = "比對結果：";
            // 
            // lblMatchCount
            // 
            lblMatchCount.Font = new Font("Segoe UI", 18F);
            lblMatchCount.ForeColor = Color.Red;
            lblMatchCount.Location = new Point(756, 309);
            lblMatchCount.Margin = new Padding(4, 0, 4, 0);
            lblMatchCount.Name = "lblMatchCount";
            lblMatchCount.Size = new Size(360, 54);
            lblMatchCount.TabIndex = 11;
            // 
            // lblMatchedNumbers
            // 
            lblMatchedNumbers.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMatchedNumbers.ForeColor = Color.Red;
            lblMatchedNumbers.Location = new Point(756, 381);
            lblMatchedNumbers.Margin = new Padding(4, 0, 4, 0);
            lblMatchedNumbers.Name = "lblMatchedNumbers";
            lblMatchedNumbers.Size = new Size(360, 60);
            lblMatchedNumbers.TabIndex = 12;
            // 
            // lstDrawn
            // 
            lstDrawn.Font = new Font("Segoe UI", 14F);
            lstDrawn.FormattingEnabled = true;
            lstDrawn.ItemHeight = 38;
            lstDrawn.Location = new Point(36, 237);
            lstDrawn.Margin = new Padding(4);
            lstDrawn.Name = "lstDrawn";
            lstDrawn.Size = new Size(328, 232);
            lstDrawn.TabIndex = 8;
            lstDrawn.SelectedIndexChanged += lstDrawn_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "選擇開獎號碼檔案";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1152, 540);
            Controls.Add(lblMatchedNumbers);
            Controls.Add(lblMatchCount);
            Controls.Add(lblCompareTitle);
            Controls.Add(txtResults);
            Controls.Add(lstDrawn);
            Controls.Add(btnExit);
            Controls.Add(btnDraw);
            Controls.Add(btnGenerate);
            Controls.Add(lblNum5);
            Controls.Add(lblNum4);
            Controls.Add(lblNum3);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "樂透號碼產生器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
