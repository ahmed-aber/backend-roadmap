using Day_3__Recursion.Factorial;
using Day_3__Recursion.Fibonacci;
using Day_3__Recursion.Sum_of_Numbers;
using System;

namespace Day_3_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Factorial factorial = new Factorial();
            Fibonacci fibonacci = new Fibonacci();
            Sum sum = new Sum();

            Console.WriteLine("\n===== Results =====");
            Console.WriteLine("Factorial = " + factorial.FindFactorial(n));
            Console.WriteLine("Fibonacci = " + fibonacci.Fib(n));
            Console.WriteLine("Sum = " + sum.SumNumbers(n));
        }
    }
}