using static System.Console;

int x = 0;

while (x < 10)
{
    WriteLine(x);
    x++;
}

string? password;

//do
//{
//    Write("Enter yout password: ");
//    password = Console.ReadLine();
//} while (password != "Pa$$w0rd");

WriteLine("Correct!");

for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
};

string[] names = { "Adam", "Barry", "Charlie" };
// let array = ["asd", "asdsa"];

foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}