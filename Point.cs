using System;
using System.Collections.Generic;
using System.Text;

namespace sda_csharp_exercises
{
    class Point
    {
        private int Xposition;
        private int Yposition;

        public Point(int Xposition, int Yposition)
        {
            this.Xposition = Xposition;
            this.Yposition = Yposition;
        }


        public void Move(int Xchange, int Ychange)
        {
            Xposition += Xchange;
            Yposition += Ychange;
            Console.WriteLine($"X przesunięto o {Xchange} natomiast pozycję Y o {Ychange}");
        }

        public void Print()
        {
            Console.WriteLine($"Nowe współrzędne celu to X:{Xposition} Y:{Yposition}");
        }

    }
}
