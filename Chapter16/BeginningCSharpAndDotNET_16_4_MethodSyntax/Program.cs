

string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small",
"Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };

var queryResults = names.Select(x => x);

Console.WriteLine("Names begging with S:");
foreach (string name in queryResults)
{
    Console.WriteLine(name);
}
Console.WriteLine("Program finished, press Enter/Return to continue: ");

