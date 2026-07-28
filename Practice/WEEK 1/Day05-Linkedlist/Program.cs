namespace Day05_Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.InsertAtBeginning(20);
            list.InsertAtBeginning(10);

            list.InsertAtEnd(30);
            list.InsertAtEnd(40);

            list.Display();

            Console.WriteLine(list.Search(30));

            //list.Delete(20);

            list.Display();
        }
    }
}