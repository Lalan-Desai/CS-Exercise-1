int x = 0;
int y = 0;
int counter = 0;

Console.Write("Enter x: ");
x = int.Parse(Console.ReadLine()!);

Console.Write("Enter y: ");
y = int.Parse(Console.ReadLine()!);

for (int i = x; i<= y; i++)
{
    if (i%5 == 0)
    {
        counter++;
    }
}

Console.WriteLine($"Counter: {counter}");