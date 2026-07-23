\# Big-O Notation Summary



\## What is Big-O?



Big-O Notation is used to measure the efficiency of an algorithm. It shows how the running time or memory usage changes as the input size (n) increases.



`n` represents the number of elements.



\---



\## Time Complexity



Time Complexity describes how long an algorithm takes to run.



\### O(1) - Constant Time

The execution time does not change when the input size increases.



Example:

```csharp

Console.WriteLine(arr\[2]);

```



\---



\### O(n) - Linear Time

The algorithm processes every element once.



Example:

```csharp

foreach (var item in arr)

{

&#x20;   Console.WriteLine(item);

}

```



\---



\### O(n²) - Quadratic Time

Usually happens when there are nested loops.



Example:

```csharp

for (int i = 0; i < n; i++)

{

&#x20;   for (int j = 0; j < n; j++)

&#x20;   {

&#x20;       Console.WriteLine(i + " " + j);

&#x20;   }

}

```



\---



\### O(log n) - Logarithmic Time

The problem size is reduced by half in every step.



Example:

\- Binary Search



\---



\### O(n log n)

Common in efficient sorting algorithms like Merge Sort and Quick Sort.



\---



\## Space Complexity



Space Complexity measures the amount of memory an algorithm uses.



Example:



```csharp

int x = 10;

```



Space Complexity: \*\*O(1)\*\*



Example:



```csharp

int\[] copy = new int\[n];

```



Space Complexity: \*\*O(n)\*\*



\---



\## Time vs Space Complexity



\- Time Complexity measures execution time.

\- Space Complexity measures memory usage.



\---



\## Important Notes



\- O(1) is the fastest.

\- O(log n) is very efficient.

\- O(n) is acceptable for many problems.

\- O(n²) becomes slow with large inputs.

\- O(2ⁿ) and O(n!) are usually very expensive.



\---



\## Complexity Order (Best → Worst)



O(1) → O(log n) → O(n) → O(n log n) → O(n²) → O(2ⁿ) → O(n!)

