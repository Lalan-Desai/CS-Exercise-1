int x = 0;
int y = 0;

Console.Write("Enter x: ");
x = int.Parse(Console.ReadLine()!);

Console.Write("Enter y: ");
y = int.Parse(Console.ReadLine()!);

if (x > y)
{
    Console.WriteLine($"x({x}) is geater than y({y}).");
}
else
{
    Console.WriteLine($"y({y}) is geater than x({x}).");
}