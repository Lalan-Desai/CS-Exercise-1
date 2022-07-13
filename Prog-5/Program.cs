int n = 0;
int sum = 0;

Console.Write("Enter n: ");
n = int.Parse(Console.ReadLine()!);


for (int i = 0; i < n; i++)
{
    Console.Write($"Enter element {i+1} : ");
    sum += int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Sum of {n} elements is: {sum}.");
