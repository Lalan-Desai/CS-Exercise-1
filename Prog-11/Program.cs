
using System.Text.RegularExpressions;

List<string> abusingWords = new List<string>();
abusingWords.Add("Microsoft");
abusingWords.Add("PHP");
abusingWords.Add("CLR");

string text = "Microsoft's founder is Bill Gates. PHP is interpreted by the PHP interpreter. CLR is a managed language.";

foreach (var abuseWord in abusingWords)
{
    var regex = new Regex(abuseWord);
    foreach (Match item in regex.Matches(text))
    {
        string estriks = "";
        for (int i = 0; i < item.Groups[0].Value.Length; i++)
        {
            estriks += "*";
        }
        text = regex.Replace(text, estriks, 1);
    }
}



Console.WriteLine(text);