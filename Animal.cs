using System;
using System.Collections.Generic;
using System.Text;

namespace sda_csharp_exercises
{
    abstract class Animal
    {
        string name;
        string sound;

        public Animal(string name, string sound)
        {
            this.name = name;
            this.sound = sound;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{name} wydaje dźwięk {sound}.");
        }
    }
}
