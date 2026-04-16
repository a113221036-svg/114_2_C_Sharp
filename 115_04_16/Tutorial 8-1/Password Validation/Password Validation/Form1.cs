using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The NumberUpperCase method accepts a string argument
        // and returns the number of uppercase letters it contains.
        private int NumberUpperCase(string str)
        {
            int upperCaseCount = 0;
            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    upperCaseCount++;
                }
            }
            return upperCaseCount;
        }

        // The NumberLowerCase method accepts a string argument
        // and returns the number of lowercase letters it contains.
        private int NumberLowerCase(string str)
        {
            int lowerCaseCount = 0;
            foreach (char c in str)
            {
                if (char.IsLower(c))
                {
                    lowerCaseCount++;
                }
            }
            return lowerCaseCount;
        }

        // The NumberDigits method accepts a string argument
        // and returns the number of numeric digits it contains.
        private int NumberDigits(string str)
        {
            int digitCount = 0;
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
            }
            return digitCount;
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {   const int MIN_PASSWORD_LENGTH = 8;//密码的最小长度要求
            string password = passwordTextBox.Text;//从文本框获取用户输入的密码
            if(password.Length<MIN_PASSWORD_LENGTH)
            {
                MessageBox.Show("密码长度至少須为8個字元。");
                return;
            }

            int upperCaseCount = NumberUpperCase(password);
            int lowerCaseCount = NumberLowerCase(password);
            int digitCount = NumberDigits(password);

            StringBuilder msg = new StringBuilder("密碼檢查結果：\n");
            msg.AppendFormat("大寫字母數量: {0}\n", upperCaseCount);
            msg.AppendFormat("小寫字母數量: {0}\n", lowerCaseCount);
            msg.AppendFormat("數字數量: {0}\n", digitCount);

            if (password.Length < 8)
            {
                msg.AppendLine("密碼必須至少包含 8 個字元。");
            }
            if (upperCaseCount < 1)
            {
                msg.AppendLine("密碼必須包含至少一個大寫英文字母。");
            }
            if (lowerCaseCount < 1)
            {
                msg.AppendLine("密碼必須包含至少一個小寫英文字母。");
            }
            if (digitCount < 1)
            {
                msg.AppendLine("密碼必須包含至少一個數字。");
            }

            MessageBox.Show(msg.ToString(), "檢查結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
