using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
        // 銀行帳戶欄位，初始餘額為 $1000
        private BankAccount account;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 建立銀行帳戶實例並顯示初始餘額
            account = new BankAccount();
            balanceLabel.Text = account.Balance.ToString("C");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            // 處理存款按鈕點擊事件
            decimal amount;
            // 從存款輸入框獲取金額並進行存款
            if (decimal.TryParse(depositTextBox.Text, out amount))
            {
                account.Deposit(amount);
                balanceLabel.Text = account.Balance.ToString("C");
                depositTextBox.Clear(); // 清空輸入框
            }
            else
            {
                MessageBox.Show("請輸入有效的金額", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            // 處理提款按鈕點擊事件
            decimal amount;
            // 從提款輸入框獲取金額並進行提款
            if (decimal.TryParse(withdrawTextBox.Text, out amount))
            {
                if (amount <= account.Balance)
                {
                    account.Withdraw(amount);
                    balanceLabel.Text = account.Balance.ToString("C");
                    withdrawTextBox.Clear(); // 清空輸入框
                }
                else
                {
                    MessageBox.Show("提款金額不足", "提款失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的金額", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉應用程式視窗
            this.Close();
        }
    }
}
