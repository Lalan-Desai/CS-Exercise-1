int n = 3;


double sum = 0;

for (int i = 0; i < n; i++)
{
    sum += double.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Sum of the {n} number is: {sum}");
