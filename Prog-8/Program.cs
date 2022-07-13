using System.Text.RegularExpressions;

//Console.Write("Enter text: ");
//string text = Console.ReadLine()!;

var input = "We are living in a <upcase>house</upcase>. We are watching a <upcase>film</upcase> right now.";

var regex = new Regex("<upcase>(.*?)</upcase>");
foreach (Match item in regex.Matches(input))
{
    input = regex.Replace(input, item.Groups[1].Value.ToUpper(), 1);
}

Console.WriteLine(input);