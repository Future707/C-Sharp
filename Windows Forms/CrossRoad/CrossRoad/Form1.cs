namespace CrossRoad
{
    public partial class Form1 : Form
    {


        int followenemy = 20;
        int followenemyslow = 10;
        int musss = 30;
        string Rotate = "";

        public Form1()
        {
            InitializeComponent();

        }

        private void TimeForGame_Tick(object sender, EventArgs e)
        {

            rotatecan();
            ctrlRule();
            fýnýsh();
            tpCtrl();




        }


        private void ctrlRule()
        {
            if (pictureBox15.Bounds.IntersectsWith(pictureBox1.Bounds) || pictureBox15.Bounds.IntersectsWith(label32.Bounds) || pictureBox15.Bounds.IntersectsWith(pictureBox2.Bounds) || pictureBox15.Bounds.IntersectsWith(label26.Bounds) || pictureBox15.Bounds.IntersectsWith(label27.Bounds) || pictureBox15.Bounds.IntersectsWith(pictureBox3.Bounds) || pictureBox15.Bounds.IntersectsWith(pictureBox4.Bounds) || pictureBox15.Bounds.IntersectsWith(pictureBox5.Bounds) || pictureBox15.Bounds.IntersectsWith(pictureBox6.Bounds) || pictureBox15.Bounds.IntersectsWith(pictureBox7.Bounds) || pictureBox15.Bounds.IntersectsWith(pictureBox8.Bounds) || pictureBox15.Bounds.IntersectsWith(pictureBox9.Bounds) || pictureBox15.Bounds.IntersectsWith(pictureBox10.Bounds) || pictureBox15.Bounds.IntersectsWith(pictureBox11.Bounds) || pictureBox15.Bounds.IntersectsWith(pictureBox12.Bounds) || pictureBox15.Bounds.IntersectsWith(pictureBox13.Bounds) || pictureBox15.Bounds.IntersectsWith(pictureBox14.Bounds) || pictureBox15.Bounds.IntersectsWith(pictureBox16.Bounds) || pictureBox15.Bounds.IntersectsWith(pictureBox17.Bounds) || pictureBox15.Bounds.IntersectsWith(pictureBox18.Bounds))
            {

                TimeForGame.Stop();
                MessageBox.Show("Game Over...");
                pictureBox15.Location = new Point(683, 681);
                TimeForGame.Start();
                Rotate = "";
            }
        }


        private void fýnýsh()
        {
            if (pictureBox15.Bounds.IntersectsWith(label23.Bounds))
            {
                TimeForGame.Stop();
                MessageBox.Show("You won \n Congratilations");
                pictureBox15.Location = new Point(683, 681);
                TimeForGame.Start();
                Rotate = "";
            }
        }

        private void tpCtrl()
        {
            if (pictureBox16.Left < 1400)
            {
                pictureBox16.Left += followenemyslow;
            }
            else
            {
                pictureBox16.Location = new Point(-170, 590);
            }
            if (pictureBox17.Left < 1400)
            {
                pictureBox17.Left += followenemyslow;
            }
            else
            {
                pictureBox17.Location = new Point(-170, 590);
            }
            if (pictureBox18.Left < 1400)
            {
                pictureBox18.Left += followenemyslow;
            }
            else
            {
                pictureBox18.Location = new Point(-170, 590);
            }
            if (pictureBox1.Left < 1400)
            {
                pictureBox1.Left += followenemy;
            }
            else
            {
                pictureBox1.Location = new Point(-170, 525);
            }
            if (pictureBox3.Left < 1400)
            {
                pictureBox3.Left += followenemy;
            }
            else
            {
                pictureBox3.Location = new Point(-170, 525);
            }

            if (pictureBox4.Left < 1400)
            {
                pictureBox4.Left += followenemy;
            }
            else
            {
                pictureBox4.Location = new Point(-170, 525);
            }
            if (pictureBox2.Left < 1400)
            {
                pictureBox2.Left += followenemy;
            }
            else
            {
                pictureBox2.Location = new Point(-170, 378);
            }
            if (pictureBox5.Left < 1400)
            {
                pictureBox5.Left += followenemy;
            }
            else
            {
                pictureBox5.Location = new Point(-170, 378);
            }
            if (pictureBox6.Left < 1400)
            {
                pictureBox6.Left += followenemy;
            }
            else
            {
                pictureBox6.Location = new Point(-170, 378);
            }
            if (pictureBox7.Left < 1400)
            {
                pictureBox7.Left += followenemy;
            }
            else
            {
                pictureBox7.Location = new Point(-170, 378);
            }



            if (pictureBox8.Left > -170)
            {
                pictureBox8.Left -= followenemyslow;
            }
            else
            {
                pictureBox8.Location = new Point(1400, 284);
            }

            if (pictureBox9.Left > -170)
            {
                pictureBox9.Left -= followenemyslow;
            }
            else
            {
                pictureBox9.Location = new Point(1400, 284);
            }

            if (pictureBox10.Left > -170)
            {
                pictureBox10.Left -= followenemyslow;
            }
            else
            {
                pictureBox10.Location = new Point(1400, 284);
            }

            if (pictureBox11.Left > -170)
            {
                pictureBox11.Left -= followenemyslow;
            }
            else
            {
                pictureBox11.Location = new Point(1400, 284);
            }

            if (pictureBox12.Left > -170)
            {
                pictureBox12.Left -= followenemy;
            }
            else
            {
                pictureBox12.Location = new Point(1400, 159);
            }


            if (pictureBox13.Left > -170)
            {
                pictureBox13.Left -= followenemy;
            }
            else
            {
                pictureBox13.Location = new Point(1400, 159);
            }


            if (pictureBox14.Left > -170)
            {
                pictureBox14.Left -= followenemy;
            }
            else
            {
                pictureBox14.Location = new Point(1400, 159);
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void rotatecan()
        {
            if (Rotate == "L")
            {
                pictureBox15.Left -= musss;
            }
            if (Rotate == "R")
            {
                pictureBox15.Left += musss;
            }
            if (Rotate == "U")
            {
                pictureBox15.Top -= musss;
            }
            if (Rotate == "D")
            {
                pictureBox15.Top += musss;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Rotate = "L";
            }

            if (e.KeyCode == Keys.W)
            {
                Rotate = "U";
            }
            if (e.KeyCode == Keys.D)
            {
                Rotate = "R";
            }
            if (e.KeyCode == Keys.S)
            {
                Rotate = "D";
            }
        }
    }
}