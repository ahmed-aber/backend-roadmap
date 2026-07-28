using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_01_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack_Array<int> stack = new Stack_Array<int>(10);
            stack.Push(5);
            stack.Push(10);
            stack.Pop();
            Console.WriteLine("Peek: " + stack.Peek());
        }
    }
}
