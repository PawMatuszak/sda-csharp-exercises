using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Łatek");
            Cat cat1 = new Cat("Mruczek");

            Animal[] animals = new Animal[2];
            animals[0] = dog1;
            animals[1] = cat1;

            foreach(Animal animal in animals)
            {
                if(animal is Dog)
                {
                    Console.WriteLine("Jest psem");
                }
                else if(animal is Cat)
                {
                    Console.WriteLine("Jest kotem");
                }
                else
                {
                    Console.WriteLine("Nie wiemy jakie to zwierze");
                }
                animal.MakeSound();
            }
        }
    }
}
