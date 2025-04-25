using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace which_numbers_divided_by_7_between_0_100__Algorithm_
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void buttonresult_Click(object sender, EventArgs e)
        {
            if(textBoxID.Text == "nuh" & textBoxPassWord.Text == "nuh")
            {
                pictureBoxPri.Visible = true;
                buttonPri.Visible = true;
                pictureBoxDivi.Visible = true;
                buttonDivi.Visible = true;
                pictureBoxPerfe.Visible = true;
                buttonPerfe.Visible = true;
                

            }
        }

        private void buttonPri_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void buttonDivi_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void buttonPerfe_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
