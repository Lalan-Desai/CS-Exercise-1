using System.Linq;


string text = "aa bb cc dd";

var list = text.GroupBy(c => c).Select(g => new { Key = g.Key, Count = g.Count() });

foreach (var item in list)
{
    Console.WriteLine(item);
}