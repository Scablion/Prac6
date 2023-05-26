using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    public static class Class1
    {
        public static int[] Fib(int x)
        {
            int[] nums = new int[x];

            for (int i = 0; i < x; i++)
            {
                if (i < 2)
                    nums[i] = 1;
                else
                {
                    nums[i] = nums[i - 2] + nums[i - 1];
                }
            }

            return nums;
        }
    }
}
