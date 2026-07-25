int[] numbers = new int[5] { 50, 10, 33, 44, 12 };
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine("Sum of all elements is: {0}", sum);
