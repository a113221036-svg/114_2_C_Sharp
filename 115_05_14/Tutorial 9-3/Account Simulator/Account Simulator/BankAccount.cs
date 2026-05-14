using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Simulator
{
    // 銀行帳戶類別，用於管理帳戶的存款、提款和餘額
    class BankAccount
    {
        // 儲存帳戶餘額的私有欄位
        private decimal balance;

        // 建構子，初始化帳戶餘額為 $1000
        public BankAccount()
        {
            balance = 1000m;
        }

        // 帳戶餘額屬性，用於取得和設定餘額
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // 存款方法，將指定金額加入帳戶
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        // 提款方法，從帳戶扣除指定金額
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
        }
    }
}
