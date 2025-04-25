namespace Clock_App_2
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.button_equals = new System.Windows.Forms.Button();
            this.button_n_9 = new System.Windows.Forms.Button();
            this.button_n_8 = new System.Windows.Forms.Button();
            this.button_n_7 = new System.Windows.Forms.Button();
            this.button_Power = new System.Windows.Forms.Button();
            this.button_n_6 = new System.Windows.Forms.Button();
            this.button_n_5 = new System.Windows.Forms.Button();
            this.button_n_4 = new System.Windows.Forms.Button();
            this.button_Sqrt = new System.Windows.Forms.Button();
            this.button_n_3 = new System.Windows.Forms.Button();
            this.button_n_2 = new System.Windows.Forms.Button();
            this.button_n_1 = new System.Windows.Forms.Button();
            this.button_times = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_plu = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel_right = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_text_size = new System.Windows.Forms.Timer(this.components);
            this.button_n_0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_equals
            // 
            this.button_equals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_equals.BackColor = System.Drawing.Color.Black;
            this.button_equals.Font = new System.Drawing.Font("Digital-7", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_equals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_equals.Location = new System.Drawing.Point(261, 409);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(75, 85);
            this.button_equals.TabIndex = 15;
            this.button_equals.Text = "=";
            this.button_equals.UseVisualStyleBackColor = false;
            this.button_equals.Click += new System.EventHandler(this.button_equals_Click);
            // 
            // button_n_9
            // 
            this.button_n_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_n_9.BackColor = System.Drawing.Color.Black;
            this.button_n_9.Font = new System.Drawing.Font("Digital-7", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_n_9.ForeColor = System.Drawing.Color.Orange;
            this.button_n_9.Location = new System.Drawing.Point(180, 409);
            this.button_n_9.Name = "button_n_9";
            this.button_n_9.Size = new System.Drawing.Size(75, 85);
            this.button_n_9.TabIndex = 14;
            this.button_n_9.Text = "9";
            this.button_n_9.UseVisualStyleBackColor = false;
            this.button_n_9.Click += new System.EventHandler(this.button_n_9_Click);
            // 
            // button_n_8
            // 
            this.button_n_8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_n_8.BackColor = System.Drawing.Color.Black;
            this.button_n_8.Font = new System.Drawing.Font("Digital-7", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_n_8.ForeColor = System.Drawing.Color.Orange;
            this.button_n_8.Location = new System.Drawing.Point(99, 409);
            this.button_n_8.Name = "button_n_8";
            this.button_n_8.Size = new System.Drawing.Size(75, 85);
            this.button_n_8.TabIndex = 13;
            this.button_n_8.Text = "8";
            this.button_n_8.UseVisualStyleBackColor = false;
            this.button_n_8.Click += new System.EventHandler(this.button_n_8_Click);
            // 
            // button_n_7
            // 
            this.button_n_7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_n_7.BackColor = System.Drawing.Color.Black;
            this.button_n_7.Font = new System.Drawing.Font("Digital-7", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_n_7.ForeColor = System.Drawing.Color.Orange;
            this.button_n_7.Location = new System.Drawing.Point(18, 409);
            this.button_n_7.Name = "button_n_7";
            this.button_n_7.Size = new System.Drawing.Size(75, 85);
            this.button_n_7.TabIndex = 12;
            this.button_n_7.Text = "7";
            this.button_n_7.UseVisualStyleBackColor = false;
            this.button_n_7.Click += new System.EventHandler(this.button_n_7_Click);
            // 
            // button_Power
            // 
            this.button_Power.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Power.BackColor = System.Drawing.Color.Black;
            this.button_Power.Font = new System.Drawing.Font("Digital-7", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Power.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Power.Location = new System.Drawing.Point(261, 318);
            this.button_Power.Name = "button_Power";
            this.button_Power.Size = new System.Drawing.Size(75, 85);
            this.button_Power.TabIndex = 19;
            this.button_Power.Text = "^";
            this.button_Power.UseVisualStyleBackColor = false;
            this.button_Power.Click += new System.EventHandler(this.button_Power_Click_1);
            // 
            // button_n_6
            // 
            this.button_n_6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_n_6.BackColor = System.Drawing.Color.Black;
            this.button_n_6.Font = new System.Drawing.Font("Digital-7", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_n_6.ForeColor = System.Drawing.Color.Orange;
            this.button_n_6.Location = new System.Drawing.Point(180, 318);
            this.button_n_6.Name = "button_n_6";
            this.button_n_6.Size = new System.Drawing.Size(75, 85);
            this.button_n_6.TabIndex = 18;
            this.button_n_6.Text = "6";
            this.button_n_6.UseVisualStyleBackColor = false;
            this.button_n_6.Click += new System.EventHandler(this.button_n_6_Click);
            // 
            // button_n_5
            // 
            this.button_n_5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_n_5.BackColor = System.Drawing.Color.Black;
            this.button_n_5.Font = new System.Drawing.Font("Digital-7", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_n_5.ForeColor = System.Drawing.Color.Orange;
            this.button_n_5.Location = new System.Drawing.Point(99, 318);
            this.button_n_5.Name = "button_n_5";
            this.button_n_5.Size = new System.Drawing.Size(75, 85);
            this.button_n_5.TabIndex = 17;
            this.button_n_5.Text = "5";
            this.button_n_5.UseVisualStyleBackColor = false;
            this.button_n_5.Click += new System.EventHandler(this.button_n_5_Click);
            // 
            // button_n_4
            // 
            this.button_n_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_n_4.BackColor = System.Drawing.Color.Black;
            this.button_n_4.Font = new System.Drawing.Font("Digital-7", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_n_4.ForeColor = System.Drawing.Color.Orange;
            this.button_n_4.Location = new System.Drawing.Point(18, 318);
            this.button_n_4.Name = "button_n_4";
            this.button_n_4.Size = new System.Drawing.Size(75, 85);
            this.button_n_4.TabIndex = 16;
            this.button_n_4.Text = "4";
            this.button_n_4.UseVisualStyleBackColor = false;
            this.button_n_4.Click += new System.EventHandler(this.button_n_4_Click);
            // 
            // button_Sqrt
            // 
            this.button_Sqrt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Sqrt.BackColor = System.Drawing.Color.Black;
            this.button_Sqrt.Font = new System.Drawing.Font("Digital-7", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sqrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Sqrt.Location = new System.Drawing.Point(261, 227);
            this.button_Sqrt.Name = "button_Sqrt";
            this.button_Sqrt.Size = new System.Drawing.Size(75, 85);
            this.button_Sqrt.TabIndex = 23;
            this.button_Sqrt.Text = "√¯";
            this.button_Sqrt.UseVisualStyleBackColor = false;
            this.button_Sqrt.Click += new System.EventHandler(this.button_Sqrt_Click_1);
            // 
            // button_n_3
            // 
            this.button_n_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_n_3.BackColor = System.Drawing.Color.Black;
            this.button_n_3.Font = new System.Drawing.Font("Digital-7", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_n_3.ForeColor = System.Drawing.Color.Orange;
            this.button_n_3.Location = new System.Drawing.Point(180, 227);
            this.button_n_3.Name = "button_n_3";
            this.button_n_3.Size = new System.Drawing.Size(75, 85);
            this.button_n_3.TabIndex = 22;
            this.button_n_3.Text = "3";
            this.button_n_3.UseVisualStyleBackColor = false;
            this.button_n_3.Click += new System.EventHandler(this.button_n_3_Click);
            // 
            // button_n_2
            // 
            this.button_n_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_n_2.BackColor = System.Drawing.Color.Black;
            this.button_n_2.Font = new System.Drawing.Font("Digital-7", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_n_2.ForeColor = System.Drawing.Color.Orange;
            this.button_n_2.Location = new System.Drawing.Point(99, 227);
            this.button_n_2.Name = "button_n_2";
            this.button_n_2.Size = new System.Drawing.Size(75, 85);
            this.button_n_2.TabIndex = 21;
            this.button_n_2.Text = "2";
            this.button_n_2.UseVisualStyleBackColor = false;
            this.button_n_2.Click += new System.EventHandler(this.button_n_2_Click);
            // 
            // button_n_1
            // 
            this.button_n_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_n_1.BackColor = System.Drawing.Color.Black;
            this.button_n_1.Font = new System.Drawing.Font("Digital-7", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_n_1.ForeColor = System.Drawing.Color.Orange;
            this.button_n_1.Location = new System.Drawing.Point(18, 227);
            this.button_n_1.Name = "button_n_1";
            this.button_n_1.Size = new System.Drawing.Size(75, 85);
            this.button_n_1.TabIndex = 20;
            this.button_n_1.Text = "1";
            this.button_n_1.UseVisualStyleBackColor = false;
            this.button_n_1.Click += new System.EventHandler(this.button_n_1_Click);
            // 
            // button_times
            // 
            this.button_times.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_times.BackColor = System.Drawing.Color.Black;
            this.button_times.Font = new System.Drawing.Font("Digital-7", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_times.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_times.Location = new System.Drawing.Point(261, 136);
            this.button_times.Name = "button_times";
            this.button_times.Size = new System.Drawing.Size(75, 85);
            this.button_times.TabIndex = 27;
            this.button_times.Text = "x";
            this.button_times.UseVisualStyleBackColor = false;
            this.button_times.Click += new System.EventHandler(this.button_times_Click);
            // 
            // button_divide
            // 
            this.button_divide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_divide.BackColor = System.Drawing.Color.Black;
            this.button_divide.Font = new System.Drawing.Font("Digital-7", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_divide.Location = new System.Drawing.Point(180, 136);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(75, 85);
            this.button_divide.TabIndex = 26;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = false;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button_minus
            // 
            this.button_minus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_minus.BackColor = System.Drawing.Color.Black;
            this.button_minus.Font = new System.Drawing.Font("Digital-7", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_minus.Location = new System.Drawing.Point(99, 136);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(75, 85);
            this.button_minus.TabIndex = 25;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_plu
            // 
            this.button_plu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_plu.BackColor = System.Drawing.Color.Black;
            this.button_plu.Font = new System.Drawing.Font("Digital-7", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_plu.Location = new System.Drawing.Point(18, 136);
            this.button_plu.Name = "button_plu";
            this.button_plu.Size = new System.Drawing.Size(75, 85);
            this.button_plu.TabIndex = 24;
            this.button_plu.Text = "+";
            this.button_plu.UseVisualStyleBackColor = false;
            this.button_plu.Click += new System.EventHandler(this.button_plu_Click);
            // 
            // panel_top
            // 
            this.panel_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_top.Controls.Add(this.label2);
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(400, 32);
            this.panel_top.TabIndex = 29;
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
            this.panel_top.DoubleClick += new System.EventHandler(this.panel_top_DoubleClick);
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            this.panel_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseUp);
            // 
            // panel_right
            // 
            this.panel_right.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_right.Location = new System.Drawing.Point(357, 31);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(43, 563);
            this.panel_right.TabIndex = 30;
            this.panel_right.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_right_Paint);
            this.panel_right.DoubleClick += new System.EventHandler(this.panel_top_DoubleClick);
            this.panel_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            this.panel_right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            this.panel_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Digital-7", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 85);
            this.label1.TabIndex = 28;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // timer_text_size
            // 
            this.timer_text_size.Tick += new System.EventHandler(this.timer_text_size_Tick);
            // 
            // button_n_0
            // 
            this.button_n_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_n_0.BackColor = System.Drawing.Color.Black;
            this.button_n_0.Font = new System.Drawing.Font("Digital-7", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_n_0.ForeColor = System.Drawing.Color.Orange;
            this.button_n_0.Location = new System.Drawing.Point(99, 500);
            this.button_n_0.Name = "button_n_0";
            this.button_n_0.Size = new System.Drawing.Size(75, 85);
            this.button_n_0.TabIndex = 31;
            this.button_n_0.Text = "0";
            this.button_n_0.UseVisualStyleBackColor = false;
            this.button_n_0.Click += new System.EventHandler(this.button_n_0_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(180, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 85);
            this.button1.TabIndex = 32;
            this.button1.Text = "AC";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(261, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 85);
            this.button2.TabIndex = 33;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Digital-7", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "DIGITAL-CALCULATOR";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(401, 594);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_n_0);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_times);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plu);
            this.Controls.Add(this.button_Sqrt);
            this.Controls.Add(this.button_n_3);
            this.Controls.Add(this.button_n_2);
            this.Controls.Add(this.button_n_1);
            this.Controls.Add(this.button_Power);
            this.Controls.Add(this.button_n_6);
            this.Controls.Add(this.button_n_5);
            this.Controls.Add(this.button_n_4);
            this.Controls.Add(this.button_equals);
            this.Controls.Add(this.button_n_9);
            this.Controls.Add(this.button_n_8);
            this.Controls.Add(this.button_n_7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_equals;
        private System.Windows.Forms.Button button_n_9;
        private System.Windows.Forms.Button button_n_8;
        private System.Windows.Forms.Button button_n_7;
        private System.Windows.Forms.Button button_Power;
        private System.Windows.Forms.Button button_n_6;
        private System.Windows.Forms.Button button_n_5;
        private System.Windows.Forms.Button button_n_4;
        private System.Windows.Forms.Button button_Sqrt;
        private System.Windows.Forms.Button button_n_3;
        private System.Windows.Forms.Button button_n_2;
        private System.Windows.Forms.Button button_n_1;
        private System.Windows.Forms.Button button_times;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plu;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_text_size;
        private System.Windows.Forms.Button button_n_0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}

