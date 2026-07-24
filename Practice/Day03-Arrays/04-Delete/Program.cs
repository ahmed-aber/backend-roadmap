int[] numbers = { 10, 20, 30, 40, 50 };

int[] newArray = new int[numbers.Length - 1];

int j = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] != 30)
    {
        newArray[j] = numbers[i];
        j++;
    }
}

foreach (int num in newArray)
{
    Console.WriteLine(num);
}
