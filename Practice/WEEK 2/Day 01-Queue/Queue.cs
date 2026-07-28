using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_01_Queue
{
    internal class Queue
    {
        public int head;
        public int tail;
        public int count;
        public int[] arr;
        public Queue(int size)
        {
            arr = new int[size];
            head = 0;
            tail = -1;
            count = 0;
        }
        public void Enqueue(int item)
        {
            if (tail == arr.Length)
            {
                Console.WriteLine("Queue is full");  
            }else
            {
                arr[++tail] = item;
                count++;
            }
        }
        public int Dequeue()
        {
            if (head == -1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }

            int item = arr[head];
            head++;

            return item;
        }
        public void Display()
        {
            if (head == -1 || head > tail)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }

            for (int i = head; i <= tail; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
