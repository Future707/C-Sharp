using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency
{
    public class Moneys
    {

        public double usdQua { get; set; }
        public double eurQua { get; set; }
        public double gbpQua { get; set; }
        public double gauQua { get; set; }



        public double getQua(double a,double b)
        {
            return a / b;
        }
    }
}
