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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        

 

        private void Form1_Load(object sender, EventArgs e)
        {
          
            for (int  i = 0; i < 100; i++)
            {
                string numb = i.ToString();

                AgeCombo.Items.Add(numb);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static string X,Y,Z,T;
        
   

        private void LogIn_Click(object sender, EventArgs e)
        {
            X = name.Text;
            Y= Surname.Text;
            Z= AgeCombo.Text;
            T = EduCombo.Text;
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();


        }
    }
}
