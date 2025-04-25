using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directions
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            int x = labelplayer.Location.X;
            int y = labelplayer.Location.Y;
            if (e.KeyCode == Keys.A)
            {
                x -= 10;
                labelplayer.Location=new Point(x, y);
            }
            if (e.KeyCode == Keys.D)
            {
                x += 10;
                labelplayer.Location = new Point(x, y);
            }
            if (e.KeyCode == Keys.W)
            {
                y -= 10;
                labelplayer.Location = new Point(x, y);
            }
            if (e.KeyCode == Keys.S)
            {
                y += 10;
                labelplayer.Location = new Point(x, y);
            }
            if (labelplayer.Right >= labelright.Left)
            {
                labelright.BackColor = Color.LimeGreen;
            }
            if(labelplayer.Top <= labeltop.Bottom)
            {
                labeltop.BackColor = Color.LimeGreen;
            }

            
        }

        
    }
}
