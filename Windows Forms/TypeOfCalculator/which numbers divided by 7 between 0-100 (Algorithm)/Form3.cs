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
    public partial class Form3 : Form
    {
        int dividnumbar;
        int querryperfect;
        public Form3()
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
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void buttonresult_Click(object sender, EventArgs e)
            
        {
            buttonresult.Visible = false;
            buttonreStart.Visible = true;
            textBoxPerfectQuerry.Enabled = false;
            int tottal = 0;
            querryperfect = Convert.ToInt32(textBoxPerfectQuerry.Text);
            for(dividnumbar = 1; dividnumbar < querryperfect; dividnumbar++)
            {
                if(querryperfect % dividnumbar == 0)
                {
                    tottal = tottal + dividnumbar;
                }
                
            }
            if(tottal == querryperfect)
            {
                labelTrue.Visible = true;

            }
            if(tottal!= querryperfect)
            {
                labelfalse.Visible = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void buttonreStart_Click(object sender, EventArgs e)
        {
            buttonreStart.Visible = false;
            buttonresult.Visible=true;
            textBoxPerfectQuerry.Enabled = true;
            textBoxPerfectQuerry.Clear();
            labelfalse.Visible = false;
            labelTrue.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
