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
    public partial class Form2 : Form
    {
        public Form2(int R,int G,int B)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(R, G, B);

        }

        public Form2(string color)
        {
            InitializeComponent();
            this.BackColor = Color.FromName(color);
        }

        
        bool Move = false;
        Point Position = new Point(683, -37);
         Point Cart = new Point(-7, -44);


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = true;
            Position = new Point(e.X, e.Y);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move )
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X-this.Position.X, p.Y-this.Position.Y);

            }
        }

        

        

     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = false;
        }

       
        
    }
}
