using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Phonebook
{
    // 用於儲存電話簿項目的結構（名字與電話）
    struct PhoneBookEntry
    {
        public string name;
        public string phone;
    }

    public partial class Form1 : Form
    {
        // 儲存 PhoneBookEntry 物件的清單
        private List<PhoneBookEntry> phoneList = 
            new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        // ReadFile 方法：讀取 PhoneList.txt 檔案內容，
        // 並將每一列轉成 PhoneBookEntry 物件加入 phoneList 清單中
        private void ReadFile()
        {
            string fileName = "PhoneList.txt";

            try
            {
                // 使用 using 自動管理資源，確保檔案正確關閉
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // 使用逗號分隔欄位
                        string[] fields = line.Split(',');
                        
                        // 建立 PhoneBookEntry 物件
                        PhoneBookEntry entry = new PhoneBookEntry();
                        entry.name = fields[0].Trim();      // 移除前後空格
                        entry.phone = fields[1].Trim();

                        // 將項目加入清單
                        phoneList.Add(entry);
                    }
                }
            }
            catch (Exception ex)
            {
                // 若讀檔發生錯誤，顯示繁體中文的錯誤訊息
                MessageBox.Show("讀取檔案時發生錯誤： " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DisplayNames 方法：將 phoneList 中的姓名顯示於 nameListBox 控制項
        private void DisplayNames()
        {
            // 清空清單方塊
            nameListBox.Items.Clear();

            // 將每筆電話簿項目的姓名加入清單方塊
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 表單載入時讀取電話清單檔案並在清單方塊中顯示姓名
            ReadFile();
            DisplayNames();
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 取得清單方塊中選取項目的索引位置
            int index = nameListBox.SelectedIndex;

            // 若有選取項目，顯示其對應的電話號碼；否則清空電話顯示欄位
            if (index >= 0 && index < phoneList.Count)
            {
                phoneLabel.Text = phoneList[index].phone;
            }
            else
            {
                phoneLabel.Text = "";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單視窗，結束程式執行
            this.Close();
        }
    }
}
