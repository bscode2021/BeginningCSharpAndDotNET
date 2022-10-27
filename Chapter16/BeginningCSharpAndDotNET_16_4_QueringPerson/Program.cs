using BeginningCSharpAndDotNET_16_4_QueringPerson;

List<Person> people = new List<Person>()
{
    new Person() { FirstName = "Alonso", LastName = "Sherman", Age = 23},
    new Person() { FirstName = "Smith", LastName = "Howells", Age = 16},
    new Person() { FirstName = "Smythe", LastName = "Warner", Age = 32},
    new Person() { FirstName = "Ilyich", LastName = "King", Age = 64},
    new Person() { FirstName = "Jones", LastName = "Bright", Age = 26},
    new Person() { FirstName = "Smith", LastName = "Walton", Age = 45},
    new Person() { FirstName = "Samba", LastName = "Warren", Age = 25},
    new Person() { FirstName = "Singh", LastName = "Flynn", Age = 18},
    new Person() { FirstName = "Fatimah", LastName = "Torres", Age = 10},
    new Person() { FirstName = "Zheng", LastName = "Chen", Age = 53},
    new Person() { FirstName = "Ruiz", LastName = "Flowers", Age = 33},
    new Person() { FirstName = "Jorgenson", LastName = "Frank", Age = 37},
    new Person() { FirstName = "Hsieh", LastName = "Howells", Age = 21}
};

//LINQ query syntax for filtering lastName that starts with "F"
var queryResult =
    from p in people
    where p.LastName.StartsWith("F")
    select p;

Console.WriteLine("LINQ with query syntax: ");
foreach (var item in queryResult)
{
    Console.WriteLine($"{item.FirstName} {item.LastName} has age of: {item.Age}");
}
Console.WriteLine();
//LINQ method syntax for filtering lastName that starts with "F"
var methodResult = people.Where(p => p.LastName.StartsWith("F"));

Console.WriteLine("LINQ with method syntax: ");
foreach (var item in methodResult)
{
    Console.WriteLine($"{item.FirstName} {item.LastName} has age of: {item.Age}");
}
Console.WriteLine();

//LINQ syntax for filtering age that is higher or equal then 21
var result =
    from item in people
    where item.Age >= 21
    orderby item.Age
    select item;

Console.WriteLine("LINQ with method syntax older then 20: ");
foreach (var item in result)
{
    Console.WriteLine($"{item.FirstName} {item.LastName} has age of: {item.Age}");
}
Console.WriteLine();