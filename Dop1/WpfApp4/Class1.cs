using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace WpfApp4
{
    public static class Class1
    {
        public static double Fxyz(int x, int y, int z)
        {
            double p = (x + y + z)/2;
            double S = Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }
    }
}
