using System;
using System.Collections.Generic;
using System.Text;

namespace Day_02_Hashing_table
{
    internal class Hashing
    {
        int BUCKET;
        List<int>[] table;
        public Hashing(int size)
        {
            BUCKET = size;
            table = new List<int>[BUCKET];
            for (int i = 0; i < BUCKET; i++)
            {
                table[i] = new List<int>();
            }
        }

        // Hash Function
        int HashFunction(int key)
        {
            return key % BUCKET;
        }

        // Insert
        public void Insert(int key)
        {
            int index = HashFunction(key);
            table[index].Add(key);
        }

        // Delete
        public void Delete(int key)
        {
            int index = HashFunction(key);
            table[index].Remove(key);
        }

        // Display
        public void Display()
        {
            for (int i = 0; i < BUCKET; i++)
            {
                Console.Write(i + " --> ");

                foreach (int item in table[i])
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
