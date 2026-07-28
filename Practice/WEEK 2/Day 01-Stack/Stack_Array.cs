using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_01_Stack
{
    internal class Stack_Array <T>
    {
        public T[] arr;
        public int top;
        public Stack_Array(int size)
        {
            arr = new T[size];
            top = -1;
        }
        public void Push(T value)
        {
            if (top == arr.Length - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }

            arr[++top] = value;
            Console.WriteLine($"Push: {value}");
        }
        public void Pop() 
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            Console.WriteLine($"Pop: {arr[top]}");
            top--;
        }
        public int Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return top;
            } else
            {
                return top;
            }
        }
    }
}
