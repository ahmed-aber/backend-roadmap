using System;
using System.Collections.Generic;

class Dictionary
{
    public static void Run()
    {
        Dictionary<int, string> employees = new Dictionary<int, string>();

        employees.Add(1, "Ahmed");
        employees.Add(2, "Ali");

        Console.WriteLine(employees[1]);
    }
}