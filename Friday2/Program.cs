using System;

namespace Friday2
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hunger;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hunger = 0;
                Console.WriteLine($"The cat {name} has been created!");
            }

            public void Sleep()
            {
                Console.WriteLine("Cat Sleeps");
                hunger += 0.2;

            }

            public void Meow()
            {
                Console.WriteLine("Muda Muda Muda");
            }

            public double Hunger
            {
                get { return hunger; }
            }

        }
        static void Main(string[] args)
        {
            Cat newCat = new Cat("Spots", "Orange");
            Console.WriteLine($"The level of happiness: {newCat.Hunger}");
            
            
            while (newCat.Hunger != 1)
            {
                newCat.Sleep();
                
            }
            newCat.Meow();
            Console.WriteLine($"The level of happiness: {newCat.Hunger}");

        }
    }
}
