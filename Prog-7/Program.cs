Console.Write("Enter a string to reverse: ");
string s = Console.ReadLine()!;

for (int i = s.Length - 1; i >= 0; i--)
{
    Console.Write(s[i]);
}

