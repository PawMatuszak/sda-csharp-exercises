using System;
using System.Collections.Generic;
using System.Text;

namespace sda_csharp_exercises
{
    class Cat : Animal
    {
        static readonly string catSound = "miau";
        public Cat(string name)
            : base(name, catSound)
        {
            
        }

    }
}
