using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp21231.physicLogics
{
    internal class pif
    {
        static double CalculateHypotenuse(int a, int b, int angle)
        {
            double c = Math.Pow(a, 2) + Math.Pow(b, 2) - (2 * a * b) * Math.Cos(angle);
            return Math.Sqrt(c);
        }


    }
}
