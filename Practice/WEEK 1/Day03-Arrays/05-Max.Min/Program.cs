
int[] numbers = new int[5] { 450, 552, 655, 5555, 855 };
int max = 0;
max = numbers[0];

int min = 0;
min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine("Max value is: {0}", max);
Console.WriteLine("Min value is: {0}", min);