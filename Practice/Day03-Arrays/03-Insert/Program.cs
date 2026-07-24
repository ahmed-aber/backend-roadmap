int[] numbers = { 10, 20, 30, 40 };

int[] newArray = new int[numbers.Length + 1];

for (int i = 0; i < numbers.Length; i++)
{
    newArray[i] = numbers[i];
}

newArray[newArray.Length - 1] = 50;

foreach (int num in newArray)
{
    Console.WriteLine(num);
}