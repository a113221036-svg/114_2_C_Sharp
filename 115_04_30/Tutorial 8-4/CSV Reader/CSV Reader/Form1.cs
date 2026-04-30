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

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;
                char[] delim = { ',' };

                using (inputFile = File.OpenText("Grades.csv"))
                {
                    string line;
                    while (!inputFile.EndOfStream)
                    {
                        line = inputFile.ReadLine();
                        if (string.IsNullOrWhiteSpace(line))
                        {
                            continue;
                        }

                        string[] fields = line.Split(delim);

                        // 新格式: 班級, 學號, 姓名, score1, score2, score3, score4, score5
                        if (fields.Length < 8)
                        {
                            MessageBox.Show("資料格式錯誤 (欄位不足): " + line);
                            continue;
                        }

                        // 跳過可能的標頭列
                        string header0 = fields[0].Trim();
                        string header1 = fields[1].Trim();
                        if (header0 == "班級" || header1 == "學號")
                        {
                            continue;
                        }

                        string className = fields[0].Trim();
                        string studentId = fields[1].Trim();
                        string studentName = fields[2].Trim();

                        int total = 0;
                        bool validScores = true;
                        for (int i = 3; i <= 7; i++)
                        {
                            string s = fields[i].Trim();
                            int score;
                            if (!int.TryParse(s, out score))
                            {
                                validScores = false;
                                break;
                            }
                            total += score;
                        }

                        if (!validScores)
                        {
                            MessageBox.Show("分數格式錯誤: " + line);
                            continue;
                        }

                        double average = (double)total / 5.0;
                        // 輸出格式：班級 學號 姓名 平均成績
                        averagesListBox.Items.Add(string.Format("{0} {1} {2} {3:F2}", className, studentId, studentName, average));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取CSV檔案時發生錯誤: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
