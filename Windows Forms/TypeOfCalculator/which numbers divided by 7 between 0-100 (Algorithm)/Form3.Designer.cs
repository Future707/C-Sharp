namespace which_numbers_divided_by_7_between_0_100__Algorithm_
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxPerfectQuerry = new System.Windows.Forms.TextBox();
            this.buttonresult = new System.Windows.Forms.Button();
            this.buttonreStart = new System.Windows.Forms.Button();
            this.labelfalse = new System.Windows.Forms.Label();
            this.labelTrue = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(8, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 66);
            this.button1.TabIndex = 22;
            this.button1.Text = "Divide";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Chartreuse;
            this.button3.Font = new System.Drawing.Font("Tw Cen MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(8, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 66);
            this.button3.TabIndex = 21;
            this.button3.Text = "Prime";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxPerfectQuerry
            // 
            this.textBoxPerfectQuerry.Font = new System.Drawing.Font("Tw Cen MT", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPerfectQuerry.Location = new System.Drawing.Point(310, 94);
            this.textBoxPerfectQuerry.Multiline = true;
            this.textBoxPerfectQuerry.Name = "textBoxPerfectQuerry";
            this.textBoxPerfectQuerry.Size = new System.Drawing.Size(186, 57);
            this.textBoxPerfectQuerry.TabIndex = 20;
            // 
            // buttonresult
            // 
            this.buttonresult.BackColor = System.Drawing.Color.Black;
            this.buttonresult.Font = new System.Drawing.Font("Tw Cen MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonresult.Location = new System.Drawing.Point(276, 169);
            this.buttonresult.Name = "buttonresult";
            this.buttonresult.Size = new System.Drawing.Size(258, 110);
            this.buttonresult.TabIndex = 19;
            this.buttonresult.Text = "Show Result";
            this.buttonresult.UseVisualStyleBackColor = false;
            this.buttonresult.Click += new System.EventHandler(this.buttonresult_Click);
            // 
            // buttonreStart
            // 
            this.buttonreStart.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonreStart.Font = new System.Drawing.Font("Tw Cen MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonreStart.ForeColor = System.Drawing.Color.Black;
            this.buttonreStart.Location = new System.Drawing.Point(540, 169);
            this.buttonreStart.Name = "buttonreStart";
            this.buttonreStart.Size = new System.Drawing.Size(258, 110);
            this.buttonreStart.TabIndex = 23;
            this.buttonreStart.Text = "ReStart";
            this.buttonreStart.UseVisualStyleBackColor = false;
            this.buttonreStart.Visible = false;
            this.buttonreStart.Click += new System.EventHandler(this.buttonreStart_Click);
            // 
            // labelfalse
            // 
            this.labelfalse.AutoSize = true;
            this.labelfalse.Font = new System.Drawing.Font("Tw Cen MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelfalse.ForeColor = System.Drawing.Color.Red;
            this.labelfalse.Location = new System.Drawing.Point(210, 24);
            this.labelfalse.Name = "labelfalse";
            this.labelfalse.Size = new System.Drawing.Size(418, 47);
            this.labelfalse.TabIndex = 24;
            this.labelfalse.Text = "This is not Perfect Number";
            this.labelfalse.Visible = false;
            // 
            // labelTrue
            // 
            this.labelTrue.AutoSize = true;
            this.labelTrue.Font = new System.Drawing.Font("Tw Cen MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelTrue.ForeColor = System.Drawing.Color.Chartreuse;
            this.labelTrue.Location = new System.Drawing.Point(268, 24);
            this.labelTrue.Name = "labelTrue";
            this.labelTrue.Size = new System.Drawing.Size(262, 47);
            this.labelTrue.TabIndex = 25;
            this.labelTrue.Text = "Perfect Number";
            this.labelTrue.Visible = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(12, 449);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(61, 28);
            this.buttonExit.TabIndex = 26;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelTrue);
            this.Controls.Add(this.labelfalse);
            this.Controls.Add(this.buttonreStart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxPerfectQuerry);
            this.Controls.Add(this.buttonresult);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Perfect";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxPerfectQuerry;
        private System.Windows.Forms.Button buttonresult;
        private System.Windows.Forms.Button buttonreStart;
        private System.Windows.Forms.Label labelfalse;
        private System.Windows.Forms.Label labelTrue;
        private System.Windows.Forms.Button buttonExit;
    }
}