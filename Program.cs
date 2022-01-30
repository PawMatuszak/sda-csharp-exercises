using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Square(5);
            Console.WriteLine(shape1.GetArea());

            Shape shape2 = new Circle(5);
            Console.WriteLine(shape2.GetArea());

            Shape[] shapes = new Shape[2];
            shapes[0] = shape1;
            shapes[1] = shape2;

            Console.WriteLine(Shape.GetTotalArea(shapes));

        }
    }
}
