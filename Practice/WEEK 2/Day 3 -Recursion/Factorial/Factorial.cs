using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3__Recursion.Factorial
{
    internal class Factorial
    {
        public int FindFactorial(int n)
        {
            if (n == 1)
                return 1;

            return n * FindFactorial(n - 1);
        }
    }
}
