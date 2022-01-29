using System;
using System.Collections.Generic;
using System.Text;

namespace sda_csharp_exercises
{
    class Dog : Animal
    {
        static readonly string catSound = "Woof";
        public Dog(string name)
            : base(name, catSound)
        {
            
        }

    }
}
