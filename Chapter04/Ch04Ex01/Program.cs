using System;

namespace Ch04Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int myInt = Convert.ToInt32(Console.ReadLine());
            bool isLessThen10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);
            Console.WriteLine($"Integer less then 10? {isLessThen10}");
            Console.WriteLine($"Integer between 0 and 5? {isBetween0And5}");
            Console.WriteLine($"Excatly on of the above is true? {isLessThen10 ^ isBetween0And5}");

            string myString  = "The number is ";
            myString += myInt < 10 ? "less then 10" : "greater then 10";

            Console.WriteLine(myString);
        }
    }
}
