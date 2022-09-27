const string myName = "boban";
const string niceName = "andrea";
const string sillyName = "plooppy";
string name;
Console.WriteLine("What is your name?");
name = Console.ReadLine();
switch (name.ToLower())
{
    case "boban":
        Console.WriteLine("You have the same name as me");
        break;
    case niceName:
        Console.WriteLine("My, what a nice name you have!");
        break;
    case sillyName:
        Console.WriteLine("That's a very silly name.");
        break;
    default:
        break;
}
Console.WriteLine($"Hello {name}!");
Console.ReadKey();

string isNameBoban = name.ToLower() == "boban" ? "Yes" : "No";