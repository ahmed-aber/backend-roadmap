using System;
using System.Collections.Generic;

namespace Day_02_Hashing_table
{
    internal class Hashingset
    {
        public void Run()
        {
            HashSet<int> numbers = new HashSet<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);

            numbers.Remove(40);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}