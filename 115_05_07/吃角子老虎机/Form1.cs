using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // 改為 10 種水果，值對應 imageList1 中的 index (0..9)
        private enum Symbol
        {
            Apple = 0,
            Banana = 1,
            Cherries = 2,
            Grapes = 3,
            Lemon = 4,
            Lime = 5,
            Orange = 6,
            Pear = 7,
            Strawberry = 8,
            Watermelon = 9
        }

        private readonly Random _rnd = new Random();
        private Symbol[] _currentSymbols = new Symbol[3];

        private decimal _balance = 000m;
        private decimal _startingBalance = 000m;
        private int _totalSpins = 0;
        private int _winCount = 0;
        private decimal _lastWin = 0m;

        public Form1()
        {
            InitializeComponent();

            // 事件註冊
            this.Load += Form1_Load;
            this.button_deposit.Click += button_deposit_Click;
            this.button1.Click += button1_Click;   // 旋轉
            this.button2.Click += button2_Click;   // 離開 / 結算
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 初始化下注選項（若 Designer 已有則保護性設定）
            if (this.comboBoxBet.Items.Count == 0)
            {
                this.comboBoxBet.Items.AddRange(new object[] { "$1", "$5", "$10", "$50" });
            }

            if (this.comboBoxBet.SelectedIndex < 0)
            {
                this.comboBoxBet.SelectedIndex = 0;
            }

            // 初始化餘額與統計
            this._balance = this._startingBalance;
            this._totalSpins = 0;
            this._winCount = 0;
            this._lastWin = 0m;

            // 顯示初始圖片（改為從 imageList1 取得）
            getImage();

            UpdateStats();
            UpdateUI();
        }

        /// <summary>
        /// 亂數決定並立即顯示三個圖片（從 imageList1 取圖；若 imageList 未備妥則 fallback 動態繪製）
        /// </summary>
        private void getImage()
        {
            // 隨機決定三個符號（0..9 共 10 種水果）
            for (int i = 0; i < 3; i++)
            {
                _currentSymbols[i] = (Symbol)_rnd.Next(0, 10);
            }

            bool hasImageList = this.imageList1 != null && this.imageList1.Images != null;

            if (hasImageList)
            {
                AssignPictureBoxImageFromImageList(this.pictureBox1, SymbolToImageListIndex(_currentSymbols[0]));
                AssignPictureBoxImageFromImageList(this.pictureBox2, SymbolToImageListIndex(_currentSymbols[1]));
                AssignPictureBoxImageFromImageList(this.pictureBox3, SymbolToImageListIndex(_currentSymbols[2]));
            }
            else
            {
                // fallback：動態繪製
                AssignPictureBoxImage(this.pictureBox1, CreateSymbolBitmap(_currentSymbols[0]));
                AssignPictureBoxImage(this.pictureBox2, CreateSymbolBitmap(_currentSymbols[1]));
                AssignPictureBoxImage(this.pictureBox3, CreateSymbolBitmap(_currentSymbols[2]));
            }
        }

        // Symbol -> imageList index 映射（enum 值已對應 imageList 的 index）
        private int SymbolToImageListIndex(Symbol s)
        {
            return (int)s;
        }

        private void AssignPictureBoxImage(PictureBox box, Image img)
        {
            if (box.Image != null)
            {
                try { box.Image.Dispose(); } catch { /* 忍錯 */ }
            }
            box.Image = img;
        }

        // 從 imageList1 取圖並 clone 指派到 PictureBox（避免直接共用 ImageList 的 Image）
        private void AssignPictureBoxImageFromImageList(PictureBox box, int index)
        {
            if (this.imageList1 == null || this.imageList1.Images == null || index < 0 || index >= this.imageList1.Images.Count)
            {
                // 若不可用則 fallback 為動態繪製（以 index 決定 Symbol 範圍 0..9）
                int idx = Math.Max(0, Math.Min(9, index));
                AssignPictureBoxImage(box, CreateSymbolBitmap((Symbol)idx));
                return;
            }

            if (box.Image != null)
            {
                try { box.Image.Dispose(); } catch { }
            }

            Image src = this.imageList1.Images[index];
            Image cloneImg;
            try
            {
                cloneImg = (Image)src.Clone();
            }
            catch
            {
                // 若 clone 失敗，退回使用來源圖（仍可顯示）
                cloneImg = src;
            }

            box.Image = cloneImg;
        }

        /// <summary>
        /// 動態繪製代表符號的 Bitmap（保留作為 fallback，支援 10 種水果）
        /// </summary>
        private Bitmap CreateSymbolBitmap(Symbol s)
        {
            int w = 120, h = 110;
            var bmp = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightYellow);

                Rectangle rect = new Rectangle(8, 8, w - 16, h - 16);

                Color color;
                string text;
                switch (s)
                {
                    case Symbol.Apple:
                        color = Color.Red; text = "Apple"; break;
                    case Symbol.Banana:
                        color = Color.Gold; text = "Banana"; break;
                    case Symbol.Cherries:
                        color = Color.DarkRed; text = "Cherries"; break;
                    case Symbol.Grapes:
                        color = Color.MediumPurple; text = "Grapes"; break;
                    case Symbol.Lemon:
                        color = Color.Yellow; text = "Lemon"; break;
                    case Symbol.Lime:
                        color = Color.LimeGreen; text = "Lime"; break;
                    case Symbol.Orange:
                        color = Color.Orange; text = "Orange"; break;
                    case Symbol.Pear:
                        color = Color.OliveDrab; text = "Pear"; break;
                    case Symbol.Strawberry:
                        color = Color.DeepPink; text = "Strawberry"; break;
                    case Symbol.Watermelon:
                        color = Color.MediumSeaGreen; text = "Watermelon"; break;
                    default:
                        color = Color.Gray; text = "Fruit"; break;
                }

                using (Brush b = new SolidBrush(color))
                {
                    g.FillEllipse(b, rect);
                }

                Rectangle inner = new Rectangle(rect.X + 10, rect.Y + 10, rect.Width - 20, rect.Height - 20);
                using (Brush b2 = new SolidBrush(Color.FromArgb(200, Color.White)))
                {
                    g.FillEllipse(b2, inner);
                }

                using (Font f = new Font("Microsoft JhengHei", 12f, FontStyle.Bold, GraphicsUnit.Point))
                using (Brush tf = new SolidBrush(Color.Black))
                {
                    SizeF size = g.MeasureString(text, f);
                    g.DrawString(text, f, tf, (w - size.Width) / 2f, (h - size.Height) / 2f);
                }

                using (Pen p = new Pen(Color.SaddleBrown, 2))
                {
                    g.DrawRectangle(p, 0, 0, w - 1, h - 1);
                }
            }
            return bmp;
        }

        /// <summary>
        /// 存入金額按鈕行為與輸入驗證
        /// </summary>
        private void button_deposit_Click(object sender, EventArgs e)
        {
            string txt = this.txtDeposit.Text?.Trim();
            if (string.IsNullOrEmpty(txt))
            {
                MessageBox.Show("請輸入存入金額。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 嘗試解析為數字（允許整數或小數）
            if (!decimal.TryParse(txt, out decimal amount))
            {
                MessageBox.Show("存入金額格式不正確，請輸入數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (amount <= 0m)
            {
                MessageBox.Show("存入金額必須大於 0。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 實際存入
            _balance += amount;
            UpdateUI();
            UpdateStats();

            // 清空輸入欄
            this.txtDeposit.Text = string.Empty;
        }

        /// <summary>
        /// 判斷中獎倍率（三段賠率）：三個相同 = 10x；任兩相同 = 2x；否則 0
        /// 傳回倍率（整數）
        /// </summary>
        private int checkWinner()
        {
            // 三個相同
            if (_currentSymbols[0] == _currentSymbols[1] && _currentSymbols[1] == _currentSymbols[2])
            {
                return 10;
            }

            // 任兩個相同
            if (_currentSymbols[0] == _currentSymbols[1] ||
                _currentSymbols[0] == _currentSymbols[2] ||
                _currentSymbols[1] == _currentSymbols[2])
            {
                return 2;
            }

            // 無中
            return 0;
        }

        /// <summary>
        /// 旋轉核心：扣款 → 顯示圖片 → 判斷並給付
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // 解析下注金額
            if (this.comboBoxBet.SelectedItem == null)
            {
                MessageBox.Show("請選擇下注金額。", "下注錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string betText = this.comboBoxBet.SelectedItem.ToString().Replace("$", string.Empty);
            if (!decimal.TryParse(betText, out decimal betAmount))
            {
                MessageBox.Show("下注金額格式錯誤。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (betAmount <= 0m)
            {
                MessageBox.Show("下注金額必須大於 0。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_balance < betAmount)
            {
                MessageBox.Show("餘額不足，請先存入或降低下注金額。", "餘額不足", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 實際扣款
            _balance -= betAmount;

            // 進行一次旋轉（即刻顯示隨機圖）
            getImage();

            // 判斷中獎
            int multiplier = checkWinner();
            decimal payout = betAmount * multiplier;

            // 紀錄
            _totalSpins++;
            _lastWin = payout;
            if (multiplier > 0)
            {
                _winCount++;
            }

            // 發放中獎
            if (payout > 0m)
            {
                _balance += payout;
            }

            UpdateStats();
            UpdateUI();
        }

        /// <summary>
        /// 更新標籤與按鈕啟用/停用邏輯
        /// </summary>
        private void UpdateUI()
        {
            // 餘額與本次獲得
            this.label_balance.Text = $"餘額： NT${_balance:F2}";
            this.label_lastWin.Text = $"本次獲得： NT${_lastWin:F2}";

            // 按鈕啟用：旋轉需有選擇下注且餘額足夠
            bool canSpin = false;
            if (this.comboBoxBet.SelectedItem != null)
            {
                string betText = this.comboBoxBet.SelectedItem.ToString().Replace("$", string.Empty);
                if (decimal.TryParse(betText, out decimal betAmount))
                {
                    canSpin = (_balance >= betAmount && betAmount > 0m);
                }
            }

            this.button1.Enabled = canSpin;
            this.button_deposit.Enabled = true; // 存入永遠可用
        }

        /// <summary>
        /// 更新統計三個標籤（旋轉、 中獎、 勝率）
        /// </summary>
        private void UpdateStats()
        {
            this.label_totalSpins.Text = $"旋轉： {_totalSpins} 次";
            this.lblWinlabel_winCount.Text = $"中獎： {_winCount} 次";

            double rate = 0.0;
            if (_totalSpins > 0)
            {
                rate = (double)_winCount / _totalSpins * 100.0;
            }
            this.label_winRate.Text = $"勝率： {rate:F1}%";
        }

        /// <summary>
        /// 離開 / 結算：顯示摘要並關閉視窗
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            decimal net = _balance - _startingBalance;
            string direction = net >= 0 ? "獲利" : "虧損";
            string message =
                $"結算摘要：\r\n" +
                $"起始餘額： NT${_startingBalance:F2}\r\n" +
                $"目前餘額： NT${_balance:F2}\r\n" +
                $"結果： {direction} NT${Math.Abs(net):F2}\r\n\r\n" +
                $"總共旋轉： {_totalSpins} 次\r\n" +
                $"中獎次數： {_winCount} 次\r\n" +
                $"勝率： {(_totalSpins>0 ? ((double)_winCount/_totalSpins*100.0).ToString("F1") : "0.0")}%";

            MessageBox.Show(message, "遊戲結算", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void label_balance_Click(object sender, EventArgs e)
        {
            // 保留空實作（Designer 原有）
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
