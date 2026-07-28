string text = "banana";
char target = 'a';

int count = 0;

for (int i = 0; i < text.Length; i++)
{
    if (text[i] == target)
    {
        count++;
    }
}

Console.WriteLine(count);
Console.ReadLine();