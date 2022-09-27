using System;

//9.1 What is wrong with the following code?
//public sealed class MyClass
//{
//    // Class members.
//}
//public class myDerivedClass : MyClass
//{
//    // Class members.
//}
//9.2 How would you define a noncreatable class?
//9.3 Why are noncreatable classes still useful? How do you make use of their capabilities?
//9.4 Write code in a class library project called Vehicles that implements the Vehicle family
//of objects discussed earlier in this chapter. There are nine objects and two interfaces that
//require implementation.
//9.5 Create a console application project, Traffic, that references Vehicles.dll (created in
//Exercise 9.4). Include a function called AddPassenger that accepts any object with the
//IPassengerCarrier interface. To prove that the code works, call this function using
//instances of each object that supports this interface, calling the ToString method
//inherited from System.Object on each one and writing the result to the screen.

namespace Ch09Exercises
{
    internal class Program
    {
        internal class MyBase
        {
            public string hello = "Hello";
        }
      
        static void Main(string[] args) 
        {
            MyClass myobj = new MyClass();
            myobj.SayHello();
            string myString = myobj.hello;
            myobj.MyIntProp = 123;
        }

        internal class MyClass : MyBase
        {
            // Field used by property.
            private int myInt;
            // Property.
            public int MyIntProp
            {
                get { return myInt; }
                set { myInt = value; }
            }
            public void SayHello()
            {
                Console.WriteLine(hello);
            }
        }
    }
}


