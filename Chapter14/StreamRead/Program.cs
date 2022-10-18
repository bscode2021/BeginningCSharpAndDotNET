using static System.Console;

string line;
try
{
    using (FileStream aFile = new FileStream("Log.txt", FileMode.Open))
    {
        using (StreamReader sr = new StreamReader(aFile))
        {
            line = sr.ReadLine();
            // Read data in line by line.
            while (line != null)
            {
                WriteLine(line);
                line = sr.ReadLine();
            }
        }
    }
}
catch (IOException e)
{
    WriteLine("An IO exception has been thrown!");
    WriteLine(e.ToString());
    return;
}
ReadLine();

MyJsonObject[] arrayOfJSON = new MyJsonObject[] {
    new MyJsonObject() { title = "", author = "", code = ""},
    new MyJsonObject() { title = "", author = "", code = ""},
    new MyJsonObject() { title = "", author = "", code = ""}
};

class MyJsonObject
{
    public string title { get; set; }
    public string author { get; set; }
    public string code { get; set; }
}



   