string text = "We are living in a house. Which is very luxurious.";

foreach (var item in text.Split('.'))
{
    if (item.Contains(" in "))
    {
        Console.WriteLine(item);
    }
}

