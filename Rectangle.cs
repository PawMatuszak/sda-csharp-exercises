using System;
using System.Collections.Generic;
using System.Text;

namespace sda_csharp_exercises
{
    class Rectangle
    {
        private int length;
        private int width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public double GetArea()
        {
            return length * width;
        }

        public double GetCircuit()
        {
            return (2 * length) + (2 * width);
        }

        public void Show()
        {
            Console.WriteLine($"Pole powierzchni prostokąta wynosi: {GetArea()}. Obwód prostoąta wynosi {GetCircuit()}");
        }

        public static void PrintClassName()
        {
            Console.WriteLine(typeof(Rectangle).Name);
        }


       
    }
}
