
using Ch10._1Exercise;

MyClass myClass = new MyClass();
myClass.ContainedString = "Test";

MyDerivedClass myDerivedClass = new MyDerivedClass();
myDerivedClass.ContainedString = "Test";

Console.WriteLine(myClass.GetString());
Console.WriteLine(myDerivedClass.GetString());