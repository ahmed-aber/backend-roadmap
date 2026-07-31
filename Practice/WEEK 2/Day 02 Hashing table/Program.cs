using Day_02_Hashing_table;
    int[] numbers = { 15, 11, 27, 8, 12 };
    Hashing h = new Hashing(7);

    foreach (int num in numbers)
    {
        h.Insert(num);
    }
    h.Delete(12);
    h.Display();
    Hashingset obj = new Hashingset();
    obj.Run();
    Dictionary.Run();
    Console.ReadKey();

