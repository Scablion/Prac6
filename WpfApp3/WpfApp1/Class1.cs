using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public static class Class1
    {
        public static int fx(int x)
        {
            if (x > 0)
                x = 1;
            else if (x < 0)
                x = -1;
            else x = 0;

            return x;
        }
    }
}
