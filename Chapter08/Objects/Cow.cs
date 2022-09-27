using System;

namespace Objects
{
    public class Cow : Animal
    {
        public Cow() : base()
        { }
        public Cow(string name, int age) : base(name, age)
        { }
        public void Moo()
        {
            Console.WriteLine($"{Name} is Mooing!");
        }
        public void SupplyMilk()
        {
            Console.WriteLine($"{Name} is supplying milk!");
        }
    }
}
