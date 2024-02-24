using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1322_Lab_6
{
    internal class FibIteration :FindFib
    {
        public int calculate_fib(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            int a = 1;
            int b = 1;
            int result = 0;

            for (int i = 3; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }
            return result;
        }
    }
}
