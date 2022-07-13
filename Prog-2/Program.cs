using Newtonsoft.Json;


Company c = new();

Console.WriteLine("---------Company Details----------");
Console.Write("Enter Name: ");
c.Name = Console.ReadLine()!;
Console.Write("Enter Address: ");
c.Address = Console.ReadLine()!;
Console.Write("Enter PhoneNumber: ");
c.PhoneNumber = Console.ReadLine()!;
Console.Write("Enter FaxNumber: ");
c.FaxNumber = Console.ReadLine()!;
Console.Write("Enter Website: ");
c.Website = Console.ReadLine()!;


Manager m = new();

Console.WriteLine("---------Manager Details----------");
Console.Write("Enter FirstName: ");
m.FirstName = Console.ReadLine()!;
Console.Write("Enter LastName: ");
m.LastName = Console.ReadLine()!;
Console.Write("Enter PhoneNumber: ");
m.PhoneNumber = Console.ReadLine()!;

c.Manager = m;

Console.Clear();
Console.WriteLine("----------Details---------");
string jsonString = System.Text.Json.JsonSerializer.Serialize(c);
string formattedJson = JsonConvert.DeserializeObject(jsonString)!.ToString()!;
Console.WriteLine(formattedJson);




