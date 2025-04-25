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
    public partial class Form2 : Form
    {
        int querryprime;
        int dividnumba;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void buttonresult_Click(object sender, EventArgs e)
        {
            textBoxPrimeQuerry.Enabled = false;
            buttonresult.Visible = false;
            int qua = 0;
            buttonre.Visible = true;
            querryprime = Convert.ToInt32(textBoxPrimeQuerry.Text);
            for (dividnumba = 1; dividnumba < querryprime; dividnumba++)
            {
                if(querryprime % dividnumba == 0)
                {
                    qua++;
                    
                }
            }

            if (qua == 1)
            {
                labeltrue.Visible = true;

            }
            if (qua != 1)
            {
                labelfalse.Visible = true;
            }
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxPrimeQuerry.Focus();
            buttonresult.Visible = true;
            buttonre.Visible = false;
            labeltrue.Visible = false;
            labelfalse.Visible=false;
            textBoxPrimeQuerry.Clear();

            textBoxPrimeQuerry.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
