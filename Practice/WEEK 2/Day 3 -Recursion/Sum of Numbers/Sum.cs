using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3__Recursion.Sum_of_Numbers
{
    internal class Sum
    {
        public int SumNumbers(int n)
        {
            if (n == 0)
                return 0;

            return n + SumNumbers(n - 1);
        }
    }
}
