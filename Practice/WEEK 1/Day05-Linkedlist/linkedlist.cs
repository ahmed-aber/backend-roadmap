using System;
using System.Collections.Generic;
using System.Text;

namespace Day05_Linkedlist
{
    class LinkedList
    {
        Node head;
        Node tail;
        public LinkedList()
        {
            head = null;
            tail = null;
        }
        public void InsertAtBeginning(int data)
        {
            Node item = new Node(data);
            if (head == null)
            {
                head = item;
                tail = item;
            }
            else
            {
                item.next = head;
                head = item;
            }
        }

        public void InsertAtEnd(int data)
        {
            Node item = new Node(data);
            if (head == null)
            {
                head = item;
                tail = item;
            }
            else
            {
                tail.next = item;
                tail = item;
            }
        }


        public void Display()
        {
            Node start = head;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                while (start != null)
                {
                    Console.Write(start.data + " ");
                    start = start.next;
                }
            }
        }

        public bool Search(int value)
        {
            Node current = head;
            int position = 0;
            while (current != null)
            {
                if (current.data == value)
                {
                    Console.WriteLine($"Value {value} found at position {position}");
                    return true;
                }
                current = current.next;
                position++;
            }
            if (current == null)
            {
                Console.WriteLine($"Value {value} not found in the list");
            }
            return false;
        }

        public void Delete(int value)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if (head.data == value)
            {
                head = head.next;
                return;
            }
            Node previous = head;
            Node current = head.next;
            while (current != null)
            {
                if (current.data == value)
                {
                    previous.next = current.next;
                    if (previous.next == null)
                    {
                        tail = previous;
                    }
                    return;
                }
                previous = previous.next;
                current = current.next;
            }
            if (current == null)
            {
                Console.WriteLine($"Value {value} not found in the list");

            }
        }
    }
}
