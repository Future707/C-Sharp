using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            Form2 Frm2 = new Form2(trackBar1.Value,trackBar2.Value,trackBar3.Value);
            Frm2.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ColorFrm = new Form2(textBox1.Text);
            ColorFrm.Show();


        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == Color.DarkGray)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }



        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.DarkGray;
                textBox1.Text = "Color Name";
            }
        }
    }
}
