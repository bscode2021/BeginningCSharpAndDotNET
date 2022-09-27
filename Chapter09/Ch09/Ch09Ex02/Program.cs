using Ch09ClassLib;
using System;

namespace Ch09Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyExternalClass myObj = new MyExternalClass();
            Console.WriteLine(myObj.ToString());
            Console.ReadKey();
        }
    }
}
