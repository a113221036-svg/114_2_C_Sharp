using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // IsValidNumber 方法
        // 說明：此方法接受一個字串參數並檢查該字串是否包含恰好 10 個數字字元（0-9）。
        // 回傳：若字串只包含數字且長度為 10，回傳 true；否則回傳 false。
        // 注意：此方法不應該改變輸入字串，只做驗證用途；格式化、錯誤顯示等行為應由事件處理程序負責。
        private bool IsValidNumber(string str)
        {
            // 檢查字串是否為 null 或空白
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            // 檢查字串長度是否恰好為 10
            if (str.Length != 10)
            {
                return false;
            }

            // 檢查字串中的所有字元是否都是數字（0-9）
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            // 所有檢查都通過，回傳 true
            return true;
        }

        // TelephoneFormat 方法
        // 說明：此方法接受一個字串參考（ref），並將其轉換為電話號碼格式，例如 (12) 2456-7890 或依專案需求的格式。
        // 備註：因為參數以 ref 傳入，呼叫端會直接接收被格式化後的字串。
        // 注意：此方法只負責字串格式化，不處理 UI 介面或驗證；呼叫此方法前應先以 IsValidNumber 驗證。
        private void TelephoneFormat(ref string str)
        {
            
        }

        // formatButton_Click 事件處理器
        // 說明：當使用者按下「格式化」按鈕時會觸發此事件。
        // 行為說明（範例流程）：
        // 1. 讀取 numberTextBox.Text 的內容。
        // 2. 使用 IsValidNumber 驗證輸入是否為 10 位數字。
        // 3. 若驗證通過，呼叫 TelephoneFormat 將字串格式化，並將結果回寫到 numberTextBox 或顯示給使用者。
        // 4. 若驗證失敗，顯示適當的錯誤訊息（例如 MessageBox）並讓使用者重新輸入。
        // 備註：此方法內的具體實作 (讀取、驗證、顯示) 目前保留，請勿在此檔案中變更邏輯。
        private void formatButton_Click(object sender, EventArgs e)
        {
            
        }

        // exitButton_Click 事件處理器
        // 說明：當使用者按下「離開」按鈕時會觸發此事件，負責關閉視窗。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
