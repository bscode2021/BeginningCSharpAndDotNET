using static System.Console;

string[] names = 
    { "Alonso", "Zheng", "Smith", "Jones", "Smythe", 
    "Small", "Ruiz", "Hsieh", "Jorgenson", "Ilyich", 
    "Singh", "Samba", "Fatimah" };

IEnumerable<string> methodQuery = names.Where(n => n.StartsWith("S"));

IEnumerable<string> queryResults =
                        from n in names
                        where n.StartsWith("S")
                        select n;

List<string> queryNames = new List<string>();
foreach (string n in names)
{
    if (n.StartsWith("S"))
    {
        queryNames.Add(n);
    }
}

WriteLine("Names beginning with S:");
foreach (var item in queryResults)
{
    WriteLine(item);
}
Write("Program finished, press Enter/Return to continue:");