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
    public partial class Form1 : Form
    {
        int textstrt, textfnsh;
        int dividnumb;
        int calculate;
        int pluss;
        int qua;

        public Form1()
        {
            InitializeComponent();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            pluss = 0;
            qua = 0;
            buttonreStart.Visible = true;
            buttonresult.Visible = false;
            groupBox1.Visible = true;
            textstrt = Convert.ToInt16(textBox1.Text);
            textfnsh = Convert.ToInt16(textBox2.Text);
            dividnumb = Convert.ToInt16(textBox3.Text);
            for(calculate = textstrt-1;calculate <=textfnsh; calculate++)
            {
                if (calculate % dividnumb == 0)
                {
                    pluss = pluss + calculate;
                    qua++;
                }
                if(calculate ==1 && dividnumb == 1)
                {
                    pluss++;
                   
                }

            }

            int quaq = qua - 1;
            labeltot.Text = pluss.ToString();
            labelqua.Text = quaq.ToString();

        }
        private void clearall()
        {
            textBox1.Focus();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            groupBox1.Visible = false;
            buttonresult.Visible = true;
            buttonreStart.Visible = false;
        }
        private void buttonreStart_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labeltot_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            clearall();
        }
    }
}
