namespace Cnake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        Panel parca;
        Panel apple = new Panel();

        List<Panel> snake = new List<Panel>();
        string route = "Right";

        private void label15_Click(object sender, EventArgs e)
        {
            label2.Text = "00";
            panel1.Controls.Clear();
            snake.Clear();
            

            label16.Visible = false;
            parca = new Panel();
            parca.Location = new Point(200, 200);
            parca.Size = new Size(20, 20);
            parca.BackColor = Color.DarkOrange;
            snake.Add(parca);
            panel1.Controls.Add(snake[0]);
            timeforgame.Start();
            createapple();
        }

        private void timeforgame_Tick(object sender, EventArgs e)
        {

            int locX = snake[0].Location.X;
            int locY = snake[0].Location.Y;
            eatapple();
            followparca();
            controlapple();

            if (route == "Right")
            {
                if (locX < 520)
                {
                    locX += 20;

                }
                else
                {
                    locX = 0;
                }
            }

            if (route == "Left")
            {
                if (locX > 0)
                {
                    locX -= 20;
                }
                else
                {
                    locX = 520;

                }




            }

            if (route == "Up")
            {
                if (locY > 0)
                {
                    locY -= 20;
                }
                else
                {
                    locY = 520;

                }

            }


            if (route == "Down")
            {
                if (locY < 520)
                {
                    locY += 20;
                }
                else
                {
                    locY = 0;
                }
            }

            snake[0].Location = new Point(locX, locY);
        }

        private void controlapple()
        {
            for (int i = 2; i < snake.Count; i++)
            {
                if (snake[0].Location == snake[i].Location)
                {
                    label16.Visible = true;
                    timeforgame.Stop();
                   
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right && route != "Left")
            {
                route = "Right";
            }
            if(e.KeyCode == Keys.Left && route != "Right")
            {
                route = "Left";
            }
            if(e.KeyCode == Keys.Up && route != "Down")
            {
                route = "Up";
            }
            if(e.KeyCode == Keys.Down && route != "Up")
            {
                route = "Down";
            }
        }
        private void createapple()
        {
            Random rast = new Random();
            int appx, appy;
            appx = rast.Next(0,520);
            appy = rast.Next(0, 520);

            appx -= appx % 20;
            appy -= appy % 20;

            apple.Size = new Size(20, 20);
            apple.BackColor = Color.Red;
            apple.Location = new Point(appx, appy);
            panel1.Controls.Add(apple);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

          
        }

        private void eatapple()
        {

            int scorepoint = int.Parse(label2.Text);

            if (snake[0].Location == apple.Location)
            {
                panel1.Controls.Remove(apple);
                scorepoint++;
                label2.Text = scorepoint.ToString();
                createapple();
                addparca();
             }
            
            
        }

        private void addparca()
        {
           Panel newparc = new Panel();
            newparc.Size = new Size(20, 20);
            newparc.BackColor = Color.Orange;
            snake.Add(newparc);
            panel1.Controls.Add(newparc);
            

        }
        private void followparca()
        {
            for(int i = snake.Count - 1; i > 0; i--)
            {
                snake[i].Location = snake[i - 1].Location;
            }
        }
    }
}