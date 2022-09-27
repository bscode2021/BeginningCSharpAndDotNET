using System;

namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chicken chicken = new Chicken("Marko", 2);
            chicken.Age += 1;

            chicken.EatFood();
            chicken.Cluck();

            chicken = new Chicken();

            chicken.Name = "Goran";
            chicken.Age = 1;

            chicken.EatFood();
            chicken.Cluck();

            Cow cow = new Cow("Milka", 12);

            cow.EatFood();
            cow.Moo();

            Animal newChicken = new Chicken("Iva", 2);
            newChicken.EatFood();

            IAnimal newChikenInt = new Chicken();
            newChikenInt.Name = "Dina";
            newChikenInt.Age = 1;

            newChikenInt.EatFood();

        }
    }
}
