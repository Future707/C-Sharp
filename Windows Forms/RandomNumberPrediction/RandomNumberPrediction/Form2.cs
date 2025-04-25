using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberPrediction
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Random rnd = new Random();
        int ranumb;

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
            ranumb = rnd.Next(1, 101);
        }

        private void CtrlRnd()
        {
            int rights = Convert.ToInt16(label7.Text);
             if(Convert.ToInt16(textBox1.Text) == ranumb)
            {
                timeRR.Enabled = false;
                MessageBox.Show("You are Winner Human :) ");
                int minna = 50 - Convert.ToInt16(label8.Text);
                label5.Text = Form1.Z.ToString() + "-year-old " + Form1.X.ToString() + " " + Form1.Y.ToString() + " found the number in " + minna.ToString() + " seconds ...";
                groupBox2.Visible = true;

                button3.Visible = true;
                button4.Visible = true;

            }
             if (Convert.ToInt16(textBox1.Text) > ranumb)
            {
                
                label6.Text = "Less";
                rights--;
                label7.Text = rights.ToString();
            }
            if (Convert.ToInt16(textBox1.Text) < ranumb)
            {
                
                label6.Text = "More";
                rights--;
                label7.Text = rights.ToString();
            }
            if(rights == 0)
            {
               
                MessageBox.Show("You Used Your Rights :( \n Please try again my Friend ...\n the Correct Answer was " + ranumb);

                button3.Visible = true;
                button4.Visible = true;

            }
        }
        
        
        private void timeRR_Tick(object sender, EventArgs e)
        {
            int time = Convert.ToInt16(label8.Text);
            if(time != 0)
            {
                time--;

            }
            else
            {
                timeRR.Enabled = false;
                MessageBox.Show("Your Time Has Expired :( \n Please try again my Friend ... \n the Correct Answer was " + ranumb);

                button3.Visible = true;
                button4.Visible = true;

            }
            label8.Text = time.ToString();

        }

       

        private void Down_Click(object sender, EventArgs e)
        {
            int query = Convert.ToInt16(textBox1.Text);
            query--;
            textBox1.Text = query.ToString();

        }

        private void Up_Click(object sender, EventArgs e)
        {
            int query = Convert.ToInt16(textBox1.Text);
            query++;
            textBox1.Text = query.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CtrlRnd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ranumb = rnd.Next(1, 101);
            textBox1.Clear();
            label7.Text = "10";
            label8.Text = "50";
            timeRR.Enabled = true;
            label6.Text = "...";
            button3.Visible = false;
            groupBox2.Visible = false;
            button4.Visible = false;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
