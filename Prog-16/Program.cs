string text = "aaabbbcccddd";

var list = text.GroupBy(c => c);

foreach (var item in list)
{
    Console.WriteLine(item.Key);
}