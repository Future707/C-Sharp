using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Currency
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

        private void Form1_Load(object sender, EventArgs e)
        {
            QuantityofMoney.Focus();
            Sec.Enabled = true;
            timerUSDGAU.Enabled = true;
            System.Threading.Thread.Sleep(770);
            timerGBPEUR.Enabled = true;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(-1, 2);
            int number2 = rnd.Next(-1, 2);
            double getusd = Math.Round(rnd.NextDouble(), 3); //USD & GAU
            double usd = (getusd * number) / 100;
            if (usd >= 0)
            {
                labelusdget.ForeColor = Color.FromArgb(0, 255, 0);
                labelusdsell.ForeColor = Color.FromArgb(0, 255, 0);
            }
            else
            {
                labelusdget.ForeColor = Color.FromArgb(255, 0, 0);
                labelusdsell.ForeColor = Color.FromArgb(255, 0, 0);

            }

            double getgau = Math.Round(rnd.NextDouble(), 3);
            double gau = (getgau * number2) / 100;

            if (gau >= 0)
            {
                labelgauget.ForeColor = Color.FromArgb(0, 255, 0);
                labelgausell.ForeColor = Color.FromArgb(0, 255, 0);
            }
            else
            {
                labelgauget.ForeColor = Color.FromArgb(255, 0, 0);
                labelgausell.ForeColor = Color.FromArgb(255, 0, 0);

            }

            labelusdget.Text = (((Convert.ToDouble(labelusdget.Text) + usd) * 1000) / 1000).ToString();
            labelusdsell.Text = (((Convert.ToDouble(labelusdsell.Text) + usd) * 1000) / 1000).ToString();


            labelgauget.Text = (((Convert.ToDouble(labelgauget.Text) + gau) * 1000) / 1000).ToString();
            labelgausell.Text = (((Convert.ToDouble(labelgausell.Text) + gau) * 1000) / 1000).ToString();




        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(-1, 2);
            int number2 = rnd.Next(-1, 2);
            double geteur = Math.Round(rnd.NextDouble(), 3);
            double eur = (geteur * number) / 100;
            if (eur >= 0)
            {
                labeleurget.ForeColor = Color.FromArgb(0, 255, 0);
                labeleursell.ForeColor = Color.FromArgb(0, 255, 0);
            }
            else
            {
                labeleurget.ForeColor = Color.FromArgb(255, 0, 0);
                labeleursell.ForeColor = Color.FromArgb(255, 0, 0);

            }

            double getgbp = Math.Round(rnd.NextDouble(), 3);
            double gbp = (getgbp * number2) / 100;

            if (gbp >= 0)
            {
                labelgbpget.ForeColor = Color.FromArgb(0, 255, 0);
                labelgbpsell.ForeColor = Color.FromArgb(0, 255, 0);
            }
            else
            {
                labelgbpget.ForeColor = Color.FromArgb(255, 0, 0);
                labelgbpsell.ForeColor = Color.FromArgb(255, 0, 0);

            }

            labeleurget.Text = (((Convert.ToDouble(labeleurget.Text) + eur) * 1000) / 1000).ToString();
            labeleursell.Text = (((Convert.ToDouble(labeleursell.Text) + eur) * 1000) / 1000).ToString();

            labelgbpget.Text = (((Convert.ToDouble(labelgbpget.Text) + gbp) * 1000) / 1000).ToString();
            labelgbpsell.Text = (((Convert.ToDouble(labelgbpsell.Text) + gbp) * 1000) / 1000).ToString();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Sec_Tick(object sender, EventArgs e)
        {
            string TEXT, TEXT2;
            int A = DateTime.Now.Minute;
            int S = DateTime.Now.Second;
            if (S < 10)
            {
                TEXT2 = ($"0{S}");
            }
            else
            {
                TEXT2 = S.ToString();
            }

            if (A < 10)
            {
                TEXT = ($"0{A}");
            }
            else
            {
                TEXT = A.ToString();
            }

            labelHourMinSec.Text = ($"{DateTime.Now.Hour}:{TEXT}:{TEXT2}");
            labelDayMonthYr.Text = ($"{DateTime.Now.DayOfWeek}/{DateTime.Now.Month}/{DateTime.Now.Year}");

            //===========================

            if (comboBoxCurrency.Text == "")
            {
                buttonBUY.Visible = false;
                buttonSELL.Visible = false;
                buttonBUYall.Visible = false;
                buttonSELLall.Visible = false;
            }
            else
            {
                buttonBUY.Visible = true;
                buttonSELL.Visible = true;
                buttonBUYall.Visible = true;
                buttonSELLall.Visible = true;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBoxTrade.ForeColor == Color.LightGray)
            {
                textBoxTrade.ForeColor = Color.Black;
                textBoxTrade.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBoxTrade.ForeColor == Color.Black && textBoxTrade.Text == "00")
            {
                textBoxTrade.ForeColor = Color.LightGray;

            }
            else if (textBoxTrade.Text == "")
            {
                textBoxTrade.ForeColor = Color.LightGray;
                textBoxTrade.Text = "00";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (QuantityofMoney.ForeColor == Color.White || QuantityofMoney.Text == "")
            {
                QuantityofMoney.ForeColor = Color.DarkGray;

            }

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (QuantityofMoney.ForeColor == Color.DarkGray)
            {
                QuantityofMoney.ForeColor = Color.White;
                QuantityofMoney.Text = "";
            }
        }

        private void labeleurget_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

            if (QuantityofMoney.Text == "")
            {
                QuantityofMoney.Text = "0";
            }

            if (Convert.ToDouble(QuantityofMoney.Text) > 0 &&
                Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)) <= 10000)
            {

                labelTLUHave.Text = (Convert.ToDouble(labelTLUHave.Text.Substring(0, (labelTLUHave.Text.Length - 1))) +
                                     Convert.ToDouble(QuantityofMoney.Text)).ToString() + "₺";
                if (Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)) > 10000)
                {
                    labelTLUHave.Text = "10000₺";
                }

            }

            QuantityofMoney.Text = "₺";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

            if (QuantityofMoney.Text == "")
            {
                QuantityofMoney.Text = "0";
            }

            if (Convert.ToDouble(QuantityofMoney.Text) > 0 && int.Parse(QuantityofMoney.Text) <=
                Convert.ToDouble(labelTLUHave.Text.Substring(0, (labelTLUHave.Text.Length - 1))))
            {

                labelTLUHave.Text = (Convert.ToDouble(labelTLUHave.Text.Substring(0, (labelTLUHave.Text.Length - 1))) -
                                     Convert.ToDouble(QuantityofMoney.Text)).ToString() + "₺";


            }

            QuantityofMoney.Text = "₺";


        }

        private void buttonBUY_Click(object sender, EventArgs e)
        {
            Moneys mn = new Moneys();
            if (Convert.ToDouble(textBoxTrade.Text) >
                Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)))
            {
                MessageBox.Show("You don't have enough money for operation...\nPlease try again...\n$-£-₺-£");
                goto last;

            }
            if (comboBoxCurrency.Text == "EUR")
            {
                mn.eurQua = mn.getQua(Convert.ToDouble(textBoxTrade.Text), Convert.ToDouble(labeleurget.Text));
                labelYourEUR.Text = mn.eurQua + "€";
                labelTLUHave.Text = (Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)) - Convert.ToDouble(textBoxTrade.Text)).ToString() + "₺";

            }
            else if (comboBoxCurrency.Text == "USD")
            {
                mn.usdQua = mn.getQua(Convert.ToDouble(textBoxTrade.Text), Convert.ToDouble(labelusdget.Text));
                labelYourUSD.Text = mn.usdQua + "$";
                labelTLUHave.Text = (Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)) -
                                     Convert.ToDouble(textBoxTrade.Text)).ToString() + "₺";
            }
            else if (comboBoxCurrency.Text == "GBP")
            {
                mn.gbpQua = mn.getQua(Convert.ToDouble(textBoxTrade.Text), Convert.ToDouble(labelgbpget.Text));
                labelYourGBP.Text = mn.gbpQua + "£";
                labelTLUHave.Text = (Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)) -
                                     Convert.ToDouble(textBoxTrade.Text)).ToString() + "₺";
            }
            else if (comboBoxCurrency.Text == "GAU")
            {
                mn.gauQua = mn.getQua(Convert.ToDouble(textBoxTrade.Text), Convert.ToDouble(labelgauget.Text));
                labelYourGAU.Text = mn.gauQua + "g";
                labelTLUHave.Text = (Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)) -
                                     Convert.ToDouble(textBoxTrade.Text)).ToString()+"₺";
            }
            last:
            textBoxTrade.Text = "00₺";
            textBoxTrade.ForeColor= Color.LightGray;

        }

        private void buttonBUYall_Click(object sender, EventArgs e)
        {
            Moneys mn = new Moneys();
           
            if (comboBoxCurrency.Text == "EUR")
            {
                mn.eurQua = mn.getQua(Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)), Convert.ToDouble(labeleurget.Text));
                labelYourEUR.Text = mn.eurQua + "€";
                labelTLUHave.Text = (Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)) - Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1))).ToString() + "₺";

            }
            else if (comboBoxCurrency.Text == "USD")
            {
                mn.usdQua = mn.getQua(Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)), Convert.ToDouble(labelusdget.Text));
                labelYourUSD.Text = mn.usdQua + "$";
                labelTLUHave.Text = (Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)) - Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1))).ToString() + "₺";
            }
            else if (comboBoxCurrency.Text == "GBP")
            {
                mn.gbpQua = mn.getQua(Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)), Convert.ToDouble(labelgbpget.Text));
                labelYourGBP.Text = mn.gbpQua + "£";
                labelTLUHave.Text = (Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)) - Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1))).ToString() + "₺";
            }
            else if (comboBoxCurrency.Text == "GAU")
            {
                mn.gauQua = mn.getQua(Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)), Convert.ToDouble(labelgauget.Text));
                labelYourGAU.Text = mn.gauQua + "g";
                labelTLUHave.Text = (Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)) - Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1))).ToString() + "₺";
            }
        last:
            textBoxTrade.Text = "00₺";
            textBoxTrade.ForeColor = Color.LightGray;
        }

        private void buttonSELL_Click(object sender, EventArgs e)
        {
            Moneys semn=new Moneys();

            if (comboBoxCurrency.Text == "EUR")
            {
                if (Convert.ToDouble(Convert.ToInt32(textBoxTrade.Text)) > Convert.ToDouble(labelYourEUR.Text.Substring(0,labelYourEUR.Text.Length-2)))
                {
                    textBoxTrade.Text =
                        (Convert.ToDouble(labelYourEUR.Text.Substring(0, labelYourEUR.Text.Length - 2)) *
                         Convert.ToDouble(labeleursell.Text)).ToString();
                }
                semn.eurQua = semn.getQua(Convert.ToDouble(textBoxTrade.Text), Convert.ToDouble(labeleursell.Text));

                labelYourEUR.Text = (Convert.ToDouble(labelYourEUR.Text.Substring(0, labelYourEUR.Text.Length - 2)) - semn.eurQua).ToString() + " €";

                labelTLUHave.Text = (Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)) +
                                     textBoxTrade.Text).ToString() + "₺";


            }
            else if (comboBoxCurrency.Text == "USD")
            {
                if (Convert.ToDouble(textBoxTrade.Text) > Convert.ToDouble(labelYourUSD.Text.Substring(0, labelYourUSD.Text.Length - 2)))
                {
                    textBoxTrade.Text =
                        (Convert.ToDouble(labelYourUSD.Text.Substring(0, labelYourUSD.Text.Length - 2)) *
                         Convert.ToDouble(labelusdsell.Text)).ToString();
                }
                semn.usdQua = semn.getQua(Convert.ToDouble(textBoxTrade.Text), Convert.ToDouble(labelusdsell.Text));

                labelYourUSD.Text = (Convert.ToDouble(labelYourUSD.Text.Substring(0, labelYourUSD.Text.Length - 2)) - semn.usdQua).ToString() + " $";

                labelTLUHave.Text = (Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)) +
                                     textBoxTrade.Text).ToString() + "₺";

            }
            else if (comboBoxCurrency.Text == "GBP")
            {
                if (Convert.ToDouble(textBoxTrade.Text) > Convert.ToDouble(labelYourGBP.Text.Substring(0, labelYourGBP.Text.Length - 2)))
                {
                    textBoxTrade.Text =
                        (Convert.ToDouble(labelYourGBP.Text.Substring(0, labelYourGBP.Text.Length - 2)) *
                         Convert.ToDouble(labelgbpsell.Text)).ToString();
                }
                semn.gbpQua = semn.getQua(Convert.ToDouble(textBoxTrade.Text), Convert.ToDouble(labelgbpsell.Text));

                labelYourGBP.Text = (Convert.ToDouble(labelYourGBP.Text.Substring(0, labelYourGAU.Text.Length - 2)) - semn.gbpQua).ToString() + " £";

                labelTLUHave.Text = (Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)) +
                                     textBoxTrade.Text).ToString() + "₺";

            }
            else if (comboBoxCurrency.Text == "GAU")
            {
                if (Convert.ToDouble(textBoxTrade.Text) > Convert.ToDouble(labelYourGAU.Text.Substring(0, labelYourGAU.Text.Length - 2)))
                {
                    textBoxTrade.Text =
                        (Convert.ToDouble(labelYourGAU.Text.Substring(0, labelYourGAU.Text.Length - 2)) *
                         Convert.ToDouble(labelgausell.Text)).ToString();
                }
                semn.gauQua = semn.getQua(Convert.ToDouble(textBoxTrade.Text), Convert.ToDouble(labelgausell.Text));

                labelYourGAU.Text=(Convert.ToDouble(labelYourGAU.Text.Substring(0, labelYourGAU.Text.Length - 2)) - semn.gauQua).ToString()+" g";
                
                labelTLUHave.Text=(Convert.ToDouble(labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)) +
                 textBoxTrade.Text).ToString()+"₺";


               
                

            }
            
            textBoxTrade.Text = "00₺";
            textBoxTrade.ForeColor = Color.LightGray;

        }

        private void buttonSELLall_Click(object sender, EventArgs e)
        {
            Moneys semn = new Moneys();

            if (comboBoxCurrency.Text == "EUR")
            {
                if (labelYourEUR.Text == "00 €")
                {
                    MessageBox.Show("You don't have any euro...\n\n$-£-₺-£");
                    goto LAST2;
                }
                semn.eurQua =
                    Convert.ToInt32(Convert.ToDouble(labelYourEUR.Text.Substring(0, labelYourEUR.Text.Length - 2)) * //I did use it for TL From all eur currency.
                     Convert.ToDouble(labeleursell.Text));

                labelYourEUR.Text ="0 €";

                labelTLUHave.Text = Convert.ToInt32(semn.eurQua + labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)).ToString()+"₺";

            }
            else if (comboBoxCurrency.Text == "USD")
            {
                if (labelYourUSD.Text == "00 $")
                {
                    MessageBox.Show("You don't have any usd...\n\n$-£-₺-£");
                    goto LAST2;
                }

                semn.usdQua =
                    Convert.ToInt32(Convert.ToDouble(labelYourUSD.Text.Substring(0,
                         labelYourUSD.Text.Length - 2)) * //I did use it for TL From all eur currency.
                     Convert.ToDouble(labelusdsell.Text));

                labelYourUSD.Text = "0 $";

                labelTLUHave.Text = Convert.ToInt32(semn.usdQua + labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)).ToString() + "₺";

            }
            else if (comboBoxCurrency.Text == "GBP")
            {
                if (labelYourGBP.Text == "00 £")
                {
                    MessageBox.Show("You don't have any pound...\n\n$-£-₺-£");
                    goto LAST2;
                }

                semn.gbpQua = Convert.ToInt32(Convert.ToDouble(labelYourGAU.Text.Substring(0, labelYourGAU.Text.Length - 2)) * Convert.ToDouble(labelgbpsell.Text));

                labelYourGBP.Text = "0 £";

                labelTLUHave.Text = Convert.ToInt32(semn.gbpQua + labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)).ToString() + "₺";

            }
            else if (comboBoxCurrency.Text == "GAU")
            {
                if (labelYourGAU.Text == "00 g")
                {
                    MessageBox.Show("You don't have any gold...\n\n$-£-₺-£");
                    goto LAST2;
                }

                semn.gauQua =
                    Convert.ToInt32(Convert.ToDouble(labelYourGAU.Text.Substring(0,
                         labelYourGAU.Text.Length - 2)) * //I did use it for TL From all eur currency.
                     Convert.ToDouble(labelgausell.Text));

                labelYourGAU.Text = "0 g";

                labelTLUHave.Text = Convert.ToInt32(semn.gauQua + labelTLUHave.Text.Substring(0, labelTLUHave.Text.Length - 1)).ToString() + "₺";
            }
        LAST2:
            MessageBox.Show("Operation succeed...\n$-£-₺-£");

        }
    }
}
