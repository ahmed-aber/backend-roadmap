\# Example 1



```csharp

Console.WriteLine(numbers\[2]);      // O(1)

```



\*\*Solution\*\*



```

Access by index



1 operation



O(1)

```



\---



\# Example 2



```csharp

foreach (int number in numbers)     // n

{

&#x20;   Console.WriteLine(number);

}

```



\*\*Solution\*\*



```

Loop = n



O(n)

```



\---



\# Example 3



```csharp

for (int i = 0; i < n; i++)         // n

{

&#x20;   for (int j = 0; j < n; j++)     // n

&#x20;   {

&#x20;       Console.WriteLine(i + j);   // 1

&#x20;   }

}

```



\*\*Solution\*\*



```

n × n



n²



O(n²)

```



\---



\# Example 4



```csharp

int i = n;



while (i > 1)       // log n

{

&#x20;   i = i / 2;

}

```



\*\*Solution\*\*



```

n

n/2

n/4

n/8

...



log₂n



O(log n)

```



\---



\# Example 5



```csharp

for (int i = 0; i < n; i++)         // n

{

&#x20;   Console.WriteLine(i);

}



for (int j = 0; j < n; j++)         // n

{

&#x20;   Console.WriteLine(j);

}

```



\*\*Solution\*\*



```

n + n



2n



O(n)

```

