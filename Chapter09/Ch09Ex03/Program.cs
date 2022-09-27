using System;

namespace Ch09Ex03
{
    class MyClass
    {
        public int Val;
    }
    struct myStruct
    {
        public int Val;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass objectA = new MyClass();
            MyClass objectB = objectA;
            objectA.Val = 10;
            objectB.Val = 20;
            myStruct structA = new myStruct();
            myStruct structB = structA;
            structA.Val = 30;
            structB.Val = 40;
            Console.WriteLine($"objectA.val = {objectA.Val}");
            Console.WriteLine($"objectB.val = {objectB.Val}");
            Console.WriteLine($"structA.val = {structA.Val}");
            Console.WriteLine($"structB.val = {structB.Val}");
            Console.ReadKey();
        }
    }
}
