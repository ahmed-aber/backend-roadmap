string text = "level";

string reverse = "";

for (int i = text.Length - 1; i >= 0; i--)
{
    reverse += text[i];
}

if (text == reverse)
{
    Console.WriteLine("Palindrome");
}
else
{
    Console.WriteLine("Not Palindrome");
}