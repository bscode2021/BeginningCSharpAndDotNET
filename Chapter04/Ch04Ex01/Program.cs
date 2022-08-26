using System;

namespace Ch04Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int myInt = Convert.ToInt32(Console.ReadLine());
            bool isLessThen10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);
            Console.WriteLine($"Integer less then 10? {isLessThen10}");
            Console.WriteLine($"Integer between 0 and 5? {isBetween0And5}");
            Console.WriteLine($"Exactly one of the above is true? {isLessThen10 ^ isBetween0And5}");
            Console.WriteLine();

            int myInteger = 12;
            string myName = "Boban";

            string resultString = (myInteger < 10) ? "Less than 10" : "Greater than or equal to 10";
            Console.WriteLine(resultString);

            string resultStringIfElse;
            if (myInteger < 10)
            {
                resultStringIfElse = "Less than 10";
            }
            else
            {
                resultStringIfElse = "Greater than or equal to 10";
            }
            Console.WriteLine(resultStringIfElse);


            string resultString2 = (myName == "Boban") ? "Your name is Boban" : "Your name is not Boban";
            Console.WriteLine(resultString2);

            string resultString2IfElse;
            if (myName == "Boban")
            {
                resultString2IfElse = "Your name is Boban";
            }
            else
            {
                resultString2IfElse = "Your name is not Boban";
            }
            Console.WriteLine(resultString2IfElse);
            
        }
    }
}
