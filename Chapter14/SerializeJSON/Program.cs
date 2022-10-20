using SerializeJSON;
using System.Text.Json;

List<Book> books = new List<Book>();

Book book1 = new Book
{
    title = "Beginning C# and .NET",
    author = "Benjamin Perkins and Jon Reid",
    code = "978-1119795780"
};
Book book2 = new Book
{
    title = "Beginning XML",
    author = "Joe Fawcett et al",
    code = "978-1118162132"
};
Book book3 = new Book
{
    title = "Professional C# 7 and .NET Core",
    author = "Christian Nagel",
    code = "978-1119449270"
};

books.Add(book1);
books.Add(book2);
books.Add(book3);

string jsonString1 = JsonSerializer.Serialize(books);
File.WriteAllText("Books.json", jsonString1);

string jsonString2 = File.ReadAllText("Books.json");
List<Book> books2 = JsonSerializer.Deserialize<List<Book>>(jsonString2);

foreach (Book b in books2)
{
    Console.WriteLine("code: {0} title: {1} author: {2}", b.code, b.title, b.author);
}

Console.WriteLine("LINQ");
var queryRes = 
    from book in books
    where book.title.StartsWith("B")
    select book.title;

foreach (var item in queryRes)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine("{");

string jsonWeatherString = File.ReadAllText("../../../Weather.json");
Weather weather = JsonSerializer.Deserialize<Weather>(jsonWeatherString);

Console.WriteLine("\t" + nameof(weather.Date) + ": " + weather.Date.ToString());
Console.WriteLine("\t" + nameof(weather.TemperatureCelsius) + ": " + weather.TemperatureCelsius.ToString());
Console.WriteLine("\t" + nameof(weather.Summary) + ": " + weather.Summary.ToString());

Console.Write("\t" + nameof(weather.DatesAvailable) + ": ");
foreach (DateTime datAvail in weather.DatesAvailable)
{
    if (weather.DatesAvailable.Last() == datAvail)
        Console.Write(datAvail.ToString());
    else
        Console.Write(datAvail.ToString() + ", ");
}
Console.WriteLine();
Console.WriteLine("\t" + nameof(weather.TemperatureRanges) + ": ");
Console.WriteLine("\t{");
Console.WriteLine("\t\t" + nameof(weather.TemperatureRanges.Cold) + ": ");
Console.WriteLine("\t\t{");
Console.WriteLine("\t\t\t" + nameof(weather.TemperatureRanges.Cold.High) + ": " + weather.TemperatureRanges.Cold.High);
Console.WriteLine("\t\t\t" + nameof(weather.TemperatureRanges.Cold.Low) + ": " + weather.TemperatureRanges.Cold.Low);
Console.WriteLine("\t\t}");
Console.WriteLine("\t\t" + nameof(weather.TemperatureRanges.Hot) + ": ");
Console.WriteLine("\t\t{");
Console.WriteLine("\t\t\t" + nameof(weather.TemperatureRanges.Hot.High) + ": " + weather.TemperatureRanges.Hot.High);
Console.WriteLine("\t\t\t" + nameof(weather.TemperatureRanges.Hot.Low) + ": " + weather.TemperatureRanges.Hot.Low);
Console.WriteLine("\t\t}");
Console.WriteLine("\t}");

Console.Write("\t" + nameof(weather.SummaryWords) + ": ");
foreach (string word in weather.SummaryWords)
{
    if (weather.SummaryWords.Last() == word)
        Console.Write(word);
    else
        Console.Write(word + ", ");
}
Console.WriteLine();
Console.WriteLine("}");
Console.ReadKey();