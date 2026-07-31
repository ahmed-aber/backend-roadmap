========================================
        HASH TABLE - QUICK NOTES
========================================

What is a Hash Table?
---------------------
A Hash Table is a data structure used for fast data lookup.

It uses a hash function to map a key to a specific location.

Average Time Complexity:
- Search : O(1)
- Insert : O(1)
- Delete : O(1)

========================================
        DICTIONARY (Key -> Value)
========================================

Definition:
Stores data as Key -> Value pairs.

Example:
1 -> Ahmed
2 -> Ali
3 -> Sara

Syntax (C#):

Dictionary<int, string> students = new Dictionary<int, string>();

Common Methods:

students.Add(1, "Ahmed");

students.ContainsKey(1);

students.Remove(1);

students[1] = "Mohamed";

Console.WriteLine(students[1]);

When to use Dictionary?
-----------------------
✔ Store Key -> Value pairs.
✔ Count frequencies.
✔ Fast lookup using a key.
✔ Mapping one value to another.

========================================
            HASHSET
========================================

Definition:
Stores UNIQUE values only.

Duplicates are NOT allowed.

Syntax (C#):

HashSet<int> numbers = new HashSet<int>();

Common Methods:

numbers.Add(5);

numbers.Contains(5);

numbers.Remove(5);

numbers.Count;

When to use HashSet?
--------------------
✔ Check if an element exists.
✔ Remove duplicates.
✔ Store unique values.
✔ Fast lookup.

========================================
      DICTIONARY vs HASHSET
========================================

Dictionary
----------
- Stores Key + Value
- Keys are unique
- Used for mapping

HashSet
-------
- Stores Values only
- Values are unique
- Used to remove duplicates
- Fast existence checking

========================================
        EXAMPLE 1
   Contains Duplicate
========================================

Input:
1 2 3 1

Output:
Duplicate

Code:

HashSet<int> set = new HashSet<int>();

foreach (int x in arr)
{
    if (set.Contains(x))
    {
        Console.WriteLine("Duplicate");
        return;
    }

    set.Add(x);
}

========================================
        EXAMPLE 2
      Frequency Count
========================================

Input:
1 2 1 3 2 1

Output:
1 -> 3
2 -> 2
3 -> 1

Code:

Dictionary<int,int> freq = new Dictionary<int,int>();

foreach(int x in arr)
{
    if(freq.ContainsKey(x))
        freq[x]++;
    else
        freq[x] = 1;
}

========================================
      COMMON PROBLEMS
========================================

1. Two Sum
2. Contains Duplicate
3. Valid Anagram
4. Group Anagrams
5. Top K Frequent Elements
6. Intersection of Two Arrays

========================================
        QUICK REVIEW
========================================

Use Dictionary if:
- You need Key -> Value.
- Count frequencies.
- Fast search by key.

Use HashSet if:
- You need unique values.
- Remove duplicates.
- Check if an element exists.

========================================
        REMEMBER
========================================

Hash Table  = Fast Lookup

Dictionary = Key -> Value

HashSet = Unique Values

Average Complexity:
Search -> O(1)
Insert -> O(1)
Delete -> O(1)

========================================