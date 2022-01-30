using System;
using System.Collections.Generic;
using System.Text;

namespace sda_csharp_exercises
{
    class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double GetArea()
        {
            return side * side;
        }
    }
}
