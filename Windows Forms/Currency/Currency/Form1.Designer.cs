namespace Currency
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelusdsell = new System.Windows.Forms.Label();
            this.labelusdget = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labeleursell = new System.Windows.Forms.Label();
            this.labeleurget = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelgbpsell = new System.Windows.Forms.Label();
            this.labelgbpget = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelgausell = new System.Windows.Forms.Label();
            this.labelgauget = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.textBoxTrade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonBUY = new System.Windows.Forms.Button();
            this.buttonBUYall = new System.Windows.Forms.Button();
            this.buttonSELLall = new System.Windows.Forms.Button();
            this.buttonSELL = new System.Windows.Forms.Button();
            this.labelHourMinSec = new System.Windows.Forms.Label();
            this.labelDayMonthYr = new System.Windows.Forms.Label();
            this.timerUSDGAU = new System.Windows.Forms.Timer(this.components);
            this.timerGBPEUR = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.QuantityofMoney = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelYourGAU = new System.Windows.Forms.Label();
            this.labelYourGBP = new System.Windows.Forms.Label();
            this.labelYourEUR = new System.Windows.Forms.Label();
            this.labelYourUSD = new System.Windows.Forms.Label();
            this.labelTLUHave = new System.Windows.Forms.Label();
            this.Sec = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelusdsell);
            this.panel1.Controls.Add(this.labelusdget);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 122);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // labelusdsell
            // 
            this.labelusdsell.AutoSize = true;
            this.labelusdsell.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusdsell.ForeColor = System.Drawing.Color.White;
            this.labelusdsell.Location = new System.Drawing.Point(337, 47);
            this.labelusdsell.Name = "labelusdsell";
            this.labelusdsell.Size = new System.Drawing.Size(80, 36);
            this.labelusdsell.TabIndex = 0;
            this.labelusdsell.Text = "19,0265";
            this.labelusdsell.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelusdget
            // 
            this.labelusdget.AutoSize = true;
            this.labelusdget.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusdget.ForeColor = System.Drawing.Color.White;
            this.labelusdget.Location = new System.Drawing.Point(188, 47);
            this.labelusdget.Name = "labelusdget";
            this.labelusdget.Size = new System.Drawing.Size(80, 36);
            this.labelusdget.TabIndex = 0;
            this.labelusdget.Text = "19,0029";
            this.labelusdget.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "USD/TRY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.labeleursell);
            this.panel2.Controls.Add(this.labeleurget);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 113);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // labeleursell
            // 
            this.labeleursell.AutoSize = true;
            this.labeleursell.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeleursell.ForeColor = System.Drawing.Color.White;
            this.labeleursell.Location = new System.Drawing.Point(337, 31);
            this.labeleursell.Name = "labeleursell";
            this.labeleursell.Size = new System.Drawing.Size(84, 36);
            this.labeleursell.TabIndex = 0;
            this.labeleursell.Text = "20,2788";
            // 
            // labeleurget
            // 
            this.labeleurget.AutoSize = true;
            this.labeleurget.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeleurget.ForeColor = System.Drawing.Color.White;
            this.labeleurget.Location = new System.Drawing.Point(188, 31);
            this.labeleurget.Name = "labeleurget";
            this.labeleurget.Size = new System.Drawing.Size(80, 36);
            this.labeleurget.TabIndex = 0;
            this.labeleurget.Text = "20,2613";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "EUR/TRY";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.labelgbpsell);
            this.panel3.Controls.Add(this.labelgbpget);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 247);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 105);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(29, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // labelgbpsell
            // 
            this.labelgbpsell.AutoSize = true;
            this.labelgbpsell.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgbpsell.ForeColor = System.Drawing.Color.White;
            this.labelgbpsell.Location = new System.Drawing.Point(337, 28);
            this.labelgbpsell.Name = "labelgbpsell";
            this.labelgbpsell.Size = new System.Drawing.Size(86, 36);
            this.labelgbpsell.TabIndex = 0;
            this.labelgbpsell.Text = "23,2002";
            // 
            // labelgbpget
            // 
            this.labelgbpget.AutoSize = true;
            this.labelgbpget.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgbpget.ForeColor = System.Drawing.Color.White;
            this.labelgbpget.Location = new System.Drawing.Point(188, 28);
            this.labelgbpget.Name = "labelgbpget";
            this.labelgbpget.Size = new System.Drawing.Size(80, 36);
            this.labelgbpget.TabIndex = 0;
            this.labelgbpget.Text = "23,1422";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "GBP/TRY";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.labelgausell);
            this.panel4.Controls.Add(this.labelgauget);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 351);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(472, 109);
            this.panel4.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(29, 37);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // labelgausell
            // 
            this.labelgausell.AutoSize = true;
            this.labelgausell.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgausell.ForeColor = System.Drawing.Color.White;
            this.labelgausell.Location = new System.Drawing.Point(337, 30);
            this.labelgausell.Name = "labelgausell";
            this.labelgausell.Size = new System.Drawing.Size(72, 36);
            this.labelgausell.TabIndex = 0;
            this.labelgausell.Text = "1.216,14";
            // 
            // labelgauget
            // 
            this.labelgauget.AutoSize = true;
            this.labelgauget.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgauget.ForeColor = System.Drawing.Color.White;
            this.labelgauget.Location = new System.Drawing.Point(188, 30);
            this.labelgauget.Name = "labelgauget";
            this.labelgauget.Size = new System.Drawing.Size(74, 36);
            this.labelgauget.TabIndex = 0;
            this.labelgauget.Text = "1.215,77";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "GAU/TRY";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.comboBoxCurrency);
            this.panel5.Controls.Add(this.textBoxTrade);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.buttonBUY);
            this.panel5.Controls.Add(this.buttonBUYall);
            this.panel5.Controls.Add(this.buttonSELLall);
            this.panel5.Controls.Add(this.buttonSELL);
            this.panel5.Location = new System.Drawing.Point(923, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(395, 196);
            this.panel5.TabIndex = 8;
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.BackColor = System.Drawing.Color.Black;
            this.comboBoxCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCurrency.Font = new System.Drawing.Font("Agency FB", 16F);
            this.comboBoxCurrency.ForeColor = System.Drawing.Color.White;
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxCurrency.Items.AddRange(new object[] {
            "EUR",
            "GAU",
            "GBP",
            "USD"});
            this.comboBoxCurrency.Location = new System.Drawing.Point(247, 47);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(76, 40);
            this.comboBoxCurrency.TabIndex = 8;
            // 
            // textBoxTrade
            // 
            this.textBoxTrade.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrade.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxTrade.Location = new System.Drawing.Point(72, 42);
            this.textBoxTrade.Multiline = true;
            this.textBoxTrade.Name = "textBoxTrade";
            this.textBoxTrade.Size = new System.Drawing.Size(169, 55);
            this.textBoxTrade.TabIndex = 7;
            this.textBoxTrade.Text = "00₺";
            this.textBoxTrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTrade.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBoxTrade.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 28);
            this.label13.TabIndex = 0;
            this.label13.Text = "Trade Corner";
            // 
            // buttonBUY
            // 
            this.buttonBUY.BackColor = System.Drawing.Color.Black;
            this.buttonBUY.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBUY.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonBUY.Location = new System.Drawing.Point(71, 103);
            this.buttonBUY.Name = "buttonBUY";
            this.buttonBUY.Size = new System.Drawing.Size(127, 68);
            this.buttonBUY.TabIndex = 1;
            this.buttonBUY.Text = "BUY";
            this.buttonBUY.UseVisualStyleBackColor = false;
            this.buttonBUY.Click += new System.EventHandler(this.buttonBUY_Click);
            // 
            // buttonBUYall
            // 
            this.buttonBUYall.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonBUYall.Font = new System.Drawing.Font("Agency FB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBUYall.ForeColor = System.Drawing.Color.Black;
            this.buttonBUYall.Location = new System.Drawing.Point(6, 115);
            this.buttonBUYall.Name = "buttonBUYall";
            this.buttonBUYall.Size = new System.Drawing.Size(59, 54);
            this.buttonBUYall.TabIndex = 1;
            this.buttonBUYall.Text = "ALL";
            this.buttonBUYall.UseVisualStyleBackColor = false;
            this.buttonBUYall.Click += new System.EventHandler(this.buttonBUYall_Click);
            // 
            // buttonSELLall
            // 
            this.buttonSELLall.BackColor = System.Drawing.Color.Red;
            this.buttonSELLall.Font = new System.Drawing.Font("Agency FB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSELLall.ForeColor = System.Drawing.Color.Black;
            this.buttonSELLall.Location = new System.Drawing.Point(328, 117);
            this.buttonSELLall.Name = "buttonSELLall";
            this.buttonSELLall.Size = new System.Drawing.Size(59, 54);
            this.buttonSELLall.TabIndex = 1;
            this.buttonSELLall.Text = "ALL";
            this.buttonSELLall.UseVisualStyleBackColor = false;
            this.buttonSELLall.Click += new System.EventHandler(this.buttonSELLall_Click);
            // 
            // buttonSELL
            // 
            this.buttonSELL.BackColor = System.Drawing.Color.Black;
            this.buttonSELL.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSELL.ForeColor = System.Drawing.Color.Red;
            this.buttonSELL.Location = new System.Drawing.Point(204, 103);
            this.buttonSELL.Name = "buttonSELL";
            this.buttonSELL.Size = new System.Drawing.Size(118, 68);
            this.buttonSELL.TabIndex = 1;
            this.buttonSELL.Text = "SELL";
            this.buttonSELL.UseVisualStyleBackColor = false;
            this.buttonSELL.Click += new System.EventHandler(this.buttonSELL_Click);
            // 
            // labelHourMinSec
            // 
            this.labelHourMinSec.AutoSize = true;
            this.labelHourMinSec.BackColor = System.Drawing.Color.Transparent;
            this.labelHourMinSec.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourMinSec.ForeColor = System.Drawing.Color.White;
            this.labelHourMinSec.Location = new System.Drawing.Point(578, 327);
            this.labelHourMinSec.Name = "labelHourMinSec";
            this.labelHourMinSec.Size = new System.Drawing.Size(276, 96);
            this.labelHourMinSec.TabIndex = 0;
            this.labelHourMinSec.Text = "00:00:00";
            this.labelHourMinSec.Click += new System.EventHandler(this.label14_Click);
            // 
            // labelDayMonthYr
            // 
            this.labelDayMonthYr.AutoSize = true;
            this.labelDayMonthYr.BackColor = System.Drawing.Color.Transparent;
            this.labelDayMonthYr.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDayMonthYr.ForeColor = System.Drawing.Color.White;
            this.labelDayMonthYr.Location = new System.Drawing.Point(588, 423);
            this.labelDayMonthYr.Name = "labelDayMonthYr";
            this.labelDayMonthYr.Size = new System.Drawing.Size(158, 35);
            this.labelDayMonthYr.TabIndex = 0;
            this.labelDayMonthYr.Text = "Day Month Year";
            // 
            // timerUSDGAU
            // 
            this.timerUSDGAU.Interval = 2000;
            this.timerUSDGAU.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timerGBPEUR
            // 
            this.timerGBPEUR.Interval = 1770;
            this.timerGBPEUR.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.labelDayMonthYr);
            this.panel6.Controls.Add(this.labelHourMinSec);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel6.Location = new System.Drawing.Point(64, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1337, 503);
            this.panel6.TabIndex = 9;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(614, 54);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(195, 255);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Controls.Add(this.QuantityofMoney);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.pictureBox5);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.buttonMinus);
            this.panel8.Controls.Add(this.buttonPlus);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.labelYourGAU);
            this.panel8.Controls.Add(this.labelYourGBP);
            this.panel8.Controls.Add(this.labelYourEUR);
            this.panel8.Controls.Add(this.labelYourUSD);
            this.panel8.Controls.Add(this.labelTLUHave);
            this.panel8.Location = new System.Drawing.Point(946, 254);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(372, 224);
            this.panel8.TabIndex = 13;
            // 
            // QuantityofMoney
            // 
            this.QuantityofMoney.BackColor = System.Drawing.Color.Black;
            this.QuantityofMoney.Font = new System.Drawing.Font("Agency FB", 12F);
            this.QuantityofMoney.ForeColor = System.Drawing.Color.DarkGray;
            this.QuantityofMoney.Location = new System.Drawing.Point(207, 183);
            this.QuantityofMoney.Multiline = true;
            this.QuantityofMoney.Name = "QuantityofMoney";
            this.QuantityofMoney.Size = new System.Drawing.Size(70, 29);
            this.QuantityofMoney.TabIndex = 7;
            this.QuantityofMoney.Text = "₺";
            this.QuantityofMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityofMoney.Enter += new System.EventHandler(this.textBox2_Enter);
            this.QuantityofMoney.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(184, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 48);
            this.label9.TabIndex = 0;
            this.label9.Text = "Budget";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(316, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 225);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "GAU/TRY";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 38);
            this.label6.TabIndex = 10;
            this.label6.Text = "GBP/TRY";
            // 
            // buttonMinus
            // 
            this.buttonMinus.AutoSize = true;
            this.buttonMinus.BackColor = System.Drawing.Color.Black;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.ForeColor = System.Drawing.Color.Red;
            this.buttonMinus.Location = new System.Drawing.Point(245, 146);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(32, 36);
            this.buttonMinus.TabIndex = 1;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.AutoSize = true;
            this.buttonPlus.BackColor = System.Drawing.Color.Black;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonPlus.Location = new System.Drawing.Point(207, 146);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(32, 36);
            this.buttonPlus.TabIndex = 1;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(17, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 38);
            this.label7.TabIndex = 11;
            this.label7.Text = "EUR/TRY";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(17, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 38);
            this.label8.TabIndex = 12;
            this.label8.Text = "USD/TRY";
            // 
            // labelYourGAU
            // 
            this.labelYourGAU.BackColor = System.Drawing.Color.DarkGray;
            this.labelYourGAU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelYourGAU.Font = new System.Drawing.Font("Agency FB", 10F);
            this.labelYourGAU.ForeColor = System.Drawing.Color.Black;
            this.labelYourGAU.Location = new System.Drawing.Point(119, 159);
            this.labelYourGAU.Name = "labelYourGAU";
            this.labelYourGAU.Size = new System.Drawing.Size(57, 38);
            this.labelYourGAU.TabIndex = 0;
            this.labelYourGAU.Text = "00 g";
            this.labelYourGAU.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelYourGBP
            // 
            this.labelYourGBP.BackColor = System.Drawing.Color.DarkGray;
            this.labelYourGBP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelYourGBP.Font = new System.Drawing.Font("Agency FB", 10F);
            this.labelYourGBP.ForeColor = System.Drawing.Color.Black;
            this.labelYourGBP.Location = new System.Drawing.Point(119, 121);
            this.labelYourGBP.Name = "labelYourGBP";
            this.labelYourGBP.Size = new System.Drawing.Size(57, 38);
            this.labelYourGBP.TabIndex = 0;
            this.labelYourGBP.Text = "00 £";
            this.labelYourGBP.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelYourEUR
            // 
            this.labelYourEUR.BackColor = System.Drawing.Color.DarkGray;
            this.labelYourEUR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelYourEUR.Font = new System.Drawing.Font("Agency FB", 10F);
            this.labelYourEUR.ForeColor = System.Drawing.Color.Black;
            this.labelYourEUR.Location = new System.Drawing.Point(119, 83);
            this.labelYourEUR.Name = "labelYourEUR";
            this.labelYourEUR.Size = new System.Drawing.Size(57, 38);
            this.labelYourEUR.TabIndex = 0;
            this.labelYourEUR.Text = "00 €";
            this.labelYourEUR.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelYourUSD
            // 
            this.labelYourUSD.BackColor = System.Drawing.Color.DarkGray;
            this.labelYourUSD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelYourUSD.Font = new System.Drawing.Font("Agency FB", 10F);
            this.labelYourUSD.ForeColor = System.Drawing.Color.Black;
            this.labelYourUSD.Location = new System.Drawing.Point(119, 45);
            this.labelYourUSD.Name = "labelYourUSD";
            this.labelYourUSD.Size = new System.Drawing.Size(57, 38);
            this.labelYourUSD.TabIndex = 0;
            this.labelYourUSD.Text = "00 $";
            this.labelYourUSD.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTLUHave
            // 
            this.labelTLUHave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTLUHave.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTLUHave.ForeColor = System.Drawing.Color.White;
            this.labelTLUHave.Location = new System.Drawing.Point(182, 99);
            this.labelTLUHave.Name = "labelTLUHave";
            this.labelTLUHave.Size = new System.Drawing.Size(120, 38);
            this.labelTLUHave.TabIndex = 0;
            this.labelTLUHave.Text = "2000₺";
            this.labelTLUHave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTLUHave.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sec
            // 
            this.Sec.Interval = 1000;
            this.Sec.Tick += new System.EventHandler(this.Sec_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1413, 558);
            this.Controls.Add(this.panel6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TradeApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelusdsell;
        private System.Windows.Forms.Label labelusdget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labeleursell;
        private System.Windows.Forms.Label labeleurget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelgbpsell;
        private System.Windows.Forms.Label labelgbpget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelgausell;
        private System.Windows.Forms.Label labelgauget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxTrade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonBUY;
        private System.Windows.Forms.Label labelDayMonthYr;
        private System.Windows.Forms.Label labelHourMinSec;
        private System.Windows.Forms.Timer timerUSDGAU;
        private System.Windows.Forms.Timer timerGBPEUR;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer Sec;
        private System.Windows.Forms.Label labelYourUSD;
        private System.Windows.Forms.Label labelYourGAU;
        private System.Windows.Forms.Label labelYourGBP;
        private System.Windows.Forms.Label labelYourEUR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button buttonSELL;
        private System.Windows.Forms.TextBox QuantityofMoney;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Label labelTLUHave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button buttonSELLall;
        private System.Windows.Forms.Button buttonBUYall;
    }
}

