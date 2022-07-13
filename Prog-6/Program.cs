int n = 0;

Console.Write("Enter n: ");
n = int.Parse(Console.ReadLine()!);

int[] intArray = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter element {i + 1} : ");
    intArray[i] += int.Parse(Console.ReadLine()!);
}

Console.Clear();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write($"{intArray[j]}");
    }
    Console.WriteLine();
}

