using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clock_App_2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer_text_size.Start();

        }

        public int c = 0;
        public string color = "default";

        private void button_n_1_Click(object sender, EventArgs e)
        {
            color = "1_color";
            if (label1.Text == "0" || label1.Text == "")
            {
                label1.Text = "1";
            }
            else
            {
                label1.Text = label1.Text + "1";
                ;
            }
        }

        private void button_n_2_Click(object sender, EventArgs e)
        {
            color = "2_color";
            if (label1.Text == "0" || label1.Text == "")
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text = label1.Text + "2";
                ;
            }
        }

        private void button_n_3_Click(object sender, EventArgs e)
        {
            color = "3_color";
            if (label1.Text == "0" || label1.Text == "")
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text = label1.Text + "3";
                ;
            }
        }

        private void button_n_4_Click(object sender, EventArgs e)
        {
            color = "4_color";
            if (label1.Text == "0" || label1.Text == "")
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text = label1.Text + "4";
                ;
            }
        }

        private void button_n_5_Click(object sender, EventArgs e)
        {
            color = "5_color";
            if (label1.Text == "0" || label1.Text == "")
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text = label1.Text + "5";
                ;
            }
        }

        private void button_n_6_Click(object sender, EventArgs e)
        {
            color = "6_color";
            if (label1.Text == "0" || label1.Text == "")
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text = label1.Text + "6";
                ;
            }
        }

        private void button_n_7_Click(object sender, EventArgs e)
        {
       
            color = "7_color";
            if (label1.Text == "0" || label1.Text == "")
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text = label1.Text + "7";
                ;
            }
        }

        private void button_n_8_Click(object sender, EventArgs e)
        {
       
            color = "8_color";
            if (label1.Text == "0" || label1.Text == "")
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text = label1.Text + "8";
                ;
            }
        }

        private void button_n_9_Click(object sender, EventArgs e)
        {
       
            color = "9_color";
            if (label1.Text == "0" || label1.Text == "")
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text = label1.Text + "9";
                ;
            }
        }

        private void timer_text_size_Tick(object sender, EventArgs e)
        {
            if (label1.Text.Length >= 9 && label1.Text.Length < 15)
            {
                label1.Font = new Font("Digital-7", 20);
            }

            if (label1.Text.Length == 15)
            {
                label1.Font = new Font("Digital-7", 15);
            }
        }

        public double first = 0;
        public double second = 0;
        public string operation = "";
        public string last_op = "";

        private void button_plu_Click(object sender, EventArgs e)
        {
            


       
            color = "plus_color";
            c++;
            last_op = operation;
            if (c == 1)
            {
                first = Convert.ToInt64(label1.Text);

            }
            else
            {
                if (last_op == "+")
                {
                    second = Convert.ToInt64(label1.Text);
                    first += second;
                }

                if (last_op == "-")
                {
                    second = Convert.ToInt64(label1.Text);
                    first -= second;
                }

                if (last_op == "/")
                {
                    second = Convert.ToInt64(label1.Text);
                    first /= second;
                }

                if (last_op == "*")
                {
                    second = Convert.ToInt64(label1.Text);
                    first *= second;
                }

                if (last_op == "pow")
                {
                    second = Convert.ToInt64(label1.Text);
                    first = Math.Pow(first, second);
                }
            }

            operation = "+";
            label1.Text = "";

        }

        private void button_minus_Click(object sender, EventArgs e)
        {
       
            color = "minus_color";
            c++;

            last_op = operation;
            if (c == 1)
            {
                first = Convert.ToInt64(label1.Text);
            }
            else
            {
                if (last_op == "+")
                {
                    second = Convert.ToInt64(label1.Text);
                    first += second;
                }

                if (last_op == "-")
                {
                    second = Convert.ToInt64(label1.Text);
                    first -= second;
                }

                if (last_op == "/")
                {
                    second = Convert.ToInt64(label1.Text);
                    first /= second;
                }

                if (last_op == "*")
                {
                    second = Convert.ToInt64(label1.Text);
                    first *= second;
                }

                if (last_op == "pow")
                {
                    second = Convert.ToInt64(label1.Text);
                    first = Math.Pow(first, second);
                }
            }

            label1.Text = "";
            operation = "-";
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
       
            color = "divide_color";
            c++;
            last_op = operation;
            if (c == 1)
            {
                first = Convert.ToInt64(label1.Text);
            }
            else
            {
                if (last_op == "+")
                {
                    second = Convert.ToInt64(label1.Text);
                    first += second;
                }

                if (last_op == "-")
                {
                    second = Convert.ToInt64(label1.Text);
                    first -= second;
                }

                if (last_op == "/")
                {
                    second = Convert.ToInt64(label1.Text);
                    first /= second;
                }

                if (last_op == "*")
                {
                    second = Convert.ToInt64(label1.Text);
                    first *= second;
                }

                if (last_op == "pow")
                {
                    second = Convert.ToInt64(label1.Text);
                    first = Math.Pow(first, second);
                }
            }

            label1.Text = "";
            operation = "/";

        }

        private void button_times_Click(object sender, EventArgs e)
        {
       
            color = "times_color";
            c++;
            last_op = operation;
            if (c == 1)
            {
                first = Convert.ToInt64(label1.Text);
            }
            else
            {
                if (last_op == "+")
                {
                    second = Convert.ToInt64(label1.Text);
                    first += second;
                }

                if (last_op == "-")
                {
                    second = Convert.ToInt64(label1.Text);
                    first -= second;
                }

                if (last_op == "/")
                {
                    second = Convert.ToInt64(label1.Text);
                    first /= second;
                }

                if (last_op == "*")
                {
                    second = Convert.ToInt64(label1.Text);
                    first *= second;
                }

                if (last_op == "pow")
                {
                    second = Convert.ToInt64(label1.Text);
                    first = Math.Pow(first, second);
                }
            }

            label1.Text = "";

            operation = "*";
        }

        private void button_Sqrt_Click(object sender, EventArgs e)
        {

        }

        private void button_Power_Click(object sender, EventArgs e)
        {

        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            color = "equal_color";
            last_op = operation;
            if (c == 1)
            {

                if (operation == "+")
                {
                    second = Convert.ToInt64(label1.Text);
                    first += second;
                }

                if (operation == "-")
                {
                    second = Convert.ToInt64(label1.Text);
                    first -= second;
                }

                if (operation == "/")
                {
                    second = Convert.ToInt64(label1.Text);
                    first /= second;
                }

                if (operation == "*")
                {
                    second = Convert.ToInt64(label1.Text);
                    first *= second;
                }

                if (operation == "pow")
                {
                    second = Convert.ToInt64(label1.Text);
                    first = Math.Pow(first, second);
                }
            }
            else
            {
                if (last_op == "+")
                {
                    second = Convert.ToInt64(label1.Text);
                    first += second;
                }

                if (last_op == "-")
                {
                    second = Convert.ToInt64(label1.Text);
                    first -= second;
                }

                if (last_op == "/")
                {
                    second = Convert.ToInt64(label1.Text);
                    first /= second;
                }

                if (last_op == "*")
                {
                    second = Convert.ToInt64(label1.Text);
                    first *= second;
                }

                if (last_op == "pow")
                {
                    second = Convert.ToInt64(label1.Text);
                    first = Math.Pow(first, second);
                }

                

            }





            label1.Text = first.ToString();
            c = 0;



        }

        private void button_Sqrt_Click_1(object sender, EventArgs e)
        {
       
            color = "sqrt_color";
            c++;
            last_op = operation;
            if (c == 1)
            {
                first = Convert.ToInt64(label1.Text);
            }
            else
            {
                if (last_op == "+")
                {
                    second = Convert.ToInt64(label1.Text);
                    first += second;
                }

                if (last_op == "-")
                {
                    second = Convert.ToInt64(label1.Text);
                    first -= second;
                }

                if (last_op == "/")
                {
                    second = Convert.ToInt64(label1.Text);
                    first /= second;
                }

                if (last_op == "*")
                {
                    second = Convert.ToInt64(label1.Text);
                    first *= second;
                }

                if (last_op == "pow")
                {
                    second = Convert.ToInt64(label1.Text);
                    first = Math.Pow(first, second);
                }
            }

            first = Math.Sqrt(first);
            label1.Text = "";
            operation = "sqrt";
        }

        private void button_Power_Click_1(object sender, EventArgs e)
        {
       
            color = "pow_color";
            c++;
            last_op = operation;
            if (c == 1)
            {
                first = Convert.ToInt64(label1.Text);
            }
            else
            {
                if (last_op == "+")
                {
                    second = Convert.ToInt64(label1.Text);
                    first += second;
                }

                if (last_op == "-")
                {
                    second = Convert.ToInt64(label1.Text);
                    first -= second;
                }

                if (last_op == "/")
                {
                    second = Convert.ToInt64(label1.Text);
                    first /= second;
                }

                if (last_op == "*")
                {
                    second = Convert.ToInt64(label1.Text);
                    first *= second;
                }

                if (last_op == "pow")
                {
                    second = Convert.ToInt64(label1.Text);
                    first = Math.Pow(first, second);
                }
            }

            label1.Text = "";
            operation = "pow";
        }

        private void button_n_0_Click(object sender, EventArgs e)
        {
       
            color = "0_color";
            if (label1.Text == "0" || label1.Text == "")
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = label1.Text + "0";
                ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            color = "AC_color";
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            color = "C_color";
            first = 0;
            second = 0;
            c = 0;
            label1.Text = "";
        }


        public bool MOVE;
        Point Start_p = new Point(0,0);

        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            MOVE = true;
            Start_p=new Point(e.X,e.Y);
        }

        private void panel_top_MouseUp(object sender, MouseEventArgs e)
        {
            MOVE = false;
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {

            if (MOVE)
            {
                Point p = PointToScreen(e.Location);
                Location=new Point(p.X - this.Start_p.X, p.Y - this.Start_p.Y);
            }
        }

        private void panel_right_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_top_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState=FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
