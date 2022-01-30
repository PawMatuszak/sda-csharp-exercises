using System;
using System.Collections.Generic;
using System.Text;

namespace sda_csharp_exercises
{
    abstract class Shape
    {
        public static double GetTotalArea(Shape[] shapes)
        {
            double totalArea = 0;

            foreach (var shape in shapes)
            {
                totalArea += shape.GetArea();
            }

            return totalArea;
        }


        abstract public double GetArea();
        

    }
}
