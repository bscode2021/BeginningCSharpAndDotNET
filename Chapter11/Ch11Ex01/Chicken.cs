using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex01
{
    public class Chicken : Animal
    {
        public void LayEgg() => Console.WriteLine($"{name} has laid egg.");
        public Chicken(string newName) : base(newName) { }
    }
}
