using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyB_rd
{
    public partial class Form1 : Form
    {

        int boruhızı = 8;
        int gravity = 15;
        int scorecode = 0;
        public Form1()
        {
            InitializeComponent();
        }

        

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            



            canki.Top += gravity;
            ust.Left -= boruhızı;
            alt.Left -= boruhızı;
            zemin.Left -= boruhızı;


            if (zemin.Left < -200)
            {
                zemin.Left = 00;
            }

            if (alt.Left < -110)
            {
                alt.Left = 570;
            }
            if(ust.Left < -110)
            {
                ust.Left = 570;
            }

            if (canki.Bounds.IntersectsWith(ust.Bounds) || canki.Bounds.IntersectsWith(alt.Bounds) || canki.Bounds.IntersectsWith(zemin.Bounds))
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                label4.Visible = true;
                label3.Visible = true;
                label7.Visible = true;

               
                 
            }
            if(alt.Left == 570)
            {
                scorecode++;

            }


            label2.Text = scorecode.ToString(); 





        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          

        }

        private void label4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Visible = false;
            label4.Visible = false;
            label7.Visible = false;
            canki.Location = new Point(20, 20);
            ust.Left = 560;
            alt.Left = 560;
            scorecode = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label5.Visible = false;
            label6.Visible = false;                      
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Canki Oynamanı İstiyor...");
        }
    }
}
