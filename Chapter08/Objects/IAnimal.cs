using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void EatFood();
        public void Breed();
    }
}
