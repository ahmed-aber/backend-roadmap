using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_01_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Display();
            Console.WriteLine(queue.Dequeue());
        }
    }
}
