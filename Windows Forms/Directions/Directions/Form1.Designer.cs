namespace Directions
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
            this.labelleft = new System.Windows.Forms.Label();
            this.labelright = new System.Windows.Forms.Label();
            this.labelbottom = new System.Windows.Forms.Label();
            this.labeltop = new System.Windows.Forms.Label();
            this.labelplayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelleft
            // 
            this.labelleft.BackColor = System.Drawing.Color.IndianRed;
            this.labelleft.Location = new System.Drawing.Point(33, 66);
            this.labelleft.Name = "labelleft";
            this.labelleft.Size = new System.Drawing.Size(19, 293);
            this.labelleft.TabIndex = 0;
            // 
            // labelright
            // 
            this.labelright.BackColor = System.Drawing.Color.IndianRed;
            this.labelright.Location = new System.Drawing.Point(722, 66);
            this.labelright.Name = "labelright";
            this.labelright.Size = new System.Drawing.Size(19, 293);
            this.labelright.TabIndex = 1;
            // 
            // labelbottom
            // 
            this.labelbottom.BackColor = System.Drawing.Color.IndianRed;
            this.labelbottom.Location = new System.Drawing.Point(48, 336);
            this.labelbottom.Name = "labelbottom";
            this.labelbottom.Size = new System.Drawing.Size(680, 23);
            this.labelbottom.TabIndex = 2;
            // 
            // labeltop
            // 
            this.labeltop.BackColor = System.Drawing.Color.IndianRed;
            this.labeltop.Location = new System.Drawing.Point(48, 66);
            this.labeltop.Name = "labeltop";
            this.labeltop.Size = new System.Drawing.Size(680, 23);
            this.labeltop.TabIndex = 3;
            // 
            // labelplayer
            // 
            this.labelplayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelplayer.Location = new System.Drawing.Point(356, 207);
            this.labelplayer.Name = "labelplayer";
            this.labelplayer.Size = new System.Drawing.Size(37, 23);
            this.labelplayer.TabIndex = 4;
            this.labelplayer.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelplayer);
            this.Controls.Add(this.labeltop);
            this.Controls.Add(this.labelbottom);
            this.Controls.Add(this.labelright);
            this.Controls.Add(this.labelleft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelleft;
        private System.Windows.Forms.Label labelright;
        private System.Windows.Forms.Label labelbottom;
        private System.Windows.Forms.Label labeltop;
        private System.Windows.Forms.Label labelplayer;
    }
}

