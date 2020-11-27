using System;

namespace Pet
{
    class Program
    {
        class Pet
        {
            string name;
            double age;
            double weight;
            double lifespan;

            public Pet(string _name)
            {
                name = _name;
                weight = 0;
                age = 0;

            }

            public void PetInfo()
            {
                Console.WriteLine($"Name: {name}; Age: {age}; Weight: {weight}; Lifespan: {lifespan} ");
            }

            public double Lifespan
            {
                get { return lifespan; }
            }

            public double Weight
            {
                get { return weight; }
            }

            public double Age
            {
                get { return age; }
            }



        }
        static void Main(string[] args)
        {
            Pet newPet = new Pet("hamster");


        }
    }
}
