namespace which_numbers_divided_by_7_between_0_100__Algorithm_
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.buttonresult = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPri = new System.Windows.Forms.PictureBox();
            this.pictureBoxDivi = new System.Windows.Forms.PictureBox();
            this.pictureBoxPerfe = new System.Windows.Forms.PictureBox();
            this.buttonPerfe = new System.Windows.Forms.Button();
            this.buttonDivi = new System.Windows.Forms.Button();
            this.buttonPri = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDivi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfe)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonresult
            // 
            this.buttonresult.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonresult.Font = new System.Drawing.Font("Tw Cen MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonresult.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonresult.Location = new System.Drawing.Point(28, 150);
            this.buttonresult.Name = "buttonresult";
            this.buttonresult.Size = new System.Drawing.Size(496, 84);
            this.buttonresult.TabIndex = 20;
            this.buttonresult.Text = "Log In";
            this.buttonresult.UseVisualStyleBackColor = false;
            this.buttonresult.Click += new System.EventHandler(this.buttonresult_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxID.Font = new System.Drawing.Font("Tw Cen MT", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(199, 12);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(186, 57);
            this.textBoxID.TabIndex = 21;
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxPassWord.Font = new System.Drawing.Font("Tw Cen MT", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassWord.Location = new System.Drawing.Point(199, 85);
            this.textBoxPassWord.Multiline = true;
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.PasswordChar = 'N';
            this.textBoxPassWord.Size = new System.Drawing.Size(186, 57);
            this.textBoxPassWord.TabIndex = 22;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Font = new System.Drawing.Font("Tw Cen MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelUser.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelUser.Location = new System.Drawing.Point(132, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(51, 47);
            this.labelUser.TabIndex = 26;
            this.labelUser.Text = "ID";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.Transparent;
            this.labelPass.Font = new System.Drawing.Font("Tw Cen MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelPass.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelPass.Location = new System.Drawing.Point(18, 85);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(165, 47);
            this.labelPass.TabIndex = 27;
            this.labelPass.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.labelPass);
            this.groupBox1.Controls.Add(this.labelUser);
            this.groupBox1.Controls.Add(this.textBoxPassWord);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.buttonresult);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(250, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 249);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOG IN";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(391, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxPri
            // 
            this.pictureBoxPri.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPri.Image")));
            this.pictureBoxPri.Location = new System.Drawing.Point(146, 400);
            this.pictureBoxPri.Name = "pictureBoxPri";
            this.pictureBoxPri.Size = new System.Drawing.Size(225, 139);
            this.pictureBoxPri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPri.TabIndex = 33;
            this.pictureBoxPri.TabStop = false;
            this.pictureBoxPri.Visible = false;
            // 
            // pictureBoxDivi
            // 
            this.pictureBoxDivi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDivi.Image")));
            this.pictureBoxDivi.Location = new System.Drawing.Point(401, 398);
            this.pictureBoxDivi.Name = "pictureBoxDivi";
            this.pictureBoxDivi.Size = new System.Drawing.Size(225, 139);
            this.pictureBoxDivi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDivi.TabIndex = 34;
            this.pictureBoxDivi.TabStop = false;
            this.pictureBoxDivi.Visible = false;
            // 
            // pictureBoxPerfe
            // 
            this.pictureBoxPerfe.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPerfe.Image")));
            this.pictureBoxPerfe.Location = new System.Drawing.Point(666, 400);
            this.pictureBoxPerfe.Name = "pictureBoxPerfe";
            this.pictureBoxPerfe.Size = new System.Drawing.Size(225, 139);
            this.pictureBoxPerfe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPerfe.TabIndex = 35;
            this.pictureBoxPerfe.TabStop = false;
            this.pictureBoxPerfe.Visible = false;
            this.pictureBoxPerfe.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // buttonPerfe
            // 
            this.buttonPerfe.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonPerfe.Font = new System.Drawing.Font("Tw Cen MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPerfe.ForeColor = System.Drawing.Color.Black;
            this.buttonPerfe.Location = new System.Drawing.Point(698, 308);
            this.buttonPerfe.Name = "buttonPerfe";
            this.buttonPerfe.Size = new System.Drawing.Size(165, 66);
            this.buttonPerfe.TabIndex = 38;
            this.buttonPerfe.Text = "Perfect";
            this.buttonPerfe.UseVisualStyleBackColor = false;
            this.buttonPerfe.Visible = false;
            this.buttonPerfe.Click += new System.EventHandler(this.buttonPerfe_Click);
            // 
            // buttonDivi
            // 
            this.buttonDivi.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonDivi.Font = new System.Drawing.Font("Tw Cen MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivi.ForeColor = System.Drawing.Color.Black;
            this.buttonDivi.Location = new System.Drawing.Point(440, 320);
            this.buttonDivi.Name = "buttonDivi";
            this.buttonDivi.Size = new System.Drawing.Size(165, 66);
            this.buttonDivi.TabIndex = 37;
            this.buttonDivi.Text = "Divide";
            this.buttonDivi.UseVisualStyleBackColor = false;
            this.buttonDivi.Visible = false;
            this.buttonDivi.Click += new System.EventHandler(this.buttonDivi_Click);
            // 
            // buttonPri
            // 
            this.buttonPri.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonPri.Font = new System.Drawing.Font("Tw Cen MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPri.ForeColor = System.Drawing.Color.Black;
            this.buttonPri.Location = new System.Drawing.Point(181, 320);
            this.buttonPri.Name = "buttonPri";
            this.buttonPri.Size = new System.Drawing.Size(165, 66);
            this.buttonPri.TabIndex = 36;
            this.buttonPri.Text = "Prime";
            this.buttonPri.UseVisualStyleBackColor = false;
            this.buttonPri.Visible = false;
            this.buttonPri.Click += new System.EventHandler(this.buttonPri_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1028, 597);
            this.Controls.Add(this.buttonPerfe);
            this.Controls.Add(this.buttonDivi);
            this.Controls.Add(this.buttonPri);
            this.Controls.Add(this.pictureBoxPerfe);
            this.Controls.Add(this.pictureBoxDivi);
            this.Controls.Add(this.pictureBoxPri);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "LOG IN Page";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDivi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonresult;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxPri;
        private System.Windows.Forms.PictureBox pictureBoxDivi;
        private System.Windows.Forms.PictureBox pictureBoxPerfe;
        private System.Windows.Forms.Button buttonPerfe;
        private System.Windows.Forms.Button buttonDivi;
        private System.Windows.Forms.Button buttonPri;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}