string url = "https://outlook.office365.com/mail/inbox";
Uri uri = new Uri(url);


Console.WriteLine($"Protocol: {uri.Scheme.ToString()}");
Console.WriteLine($"Server: {uri.Host.ToString()}");
Console.WriteLine($"Resource: {uri.LocalPath.ToString()}");