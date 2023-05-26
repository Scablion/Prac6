using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    public static class Class1
    {
        public static double fx(double x)
        {
            if (x == 1 || x == -1)
            {
                x = 1;
            }
            else if (x >= 0 && x != 1)
            {
                x = 1 / (1 - x);
            }
            else
            {
                x = 1 / (1 + x);
            }
            return x;
        }
    }
}
