using System;

namespace Ch03Ex022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("Enter your number");
            userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName}");
            Console.WriteLine("Now give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me another number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");
            Console.WriteLine($"The result of subtracting {firstNumber} and {secondNumber} is {firstNumber - secondNumber}");
            Console.WriteLine($"The product of {firstNumber} and {secondNumber} is {firstNumber * secondNumber}");
            Console.WriteLine($"The  result of deviding {firstNumber} and {secondNumber} is {firstNumber / secondNumber}");
            Console.WriteLine($"The remainder of {firstNumber} and {secondNumber} is {firstNumber % secondNumber}");
        }
    }
}
