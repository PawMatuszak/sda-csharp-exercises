using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoints punkt = new MyPoints(5, 7);
            MyPoints punkt1 = new MyPoints(1, 3);

            LineSegment linia1 = new LineSegment(punkt, punkt1);
            LineSegment linia2 = new LineSegment(5, 3, 7, 8);

            Console.WriteLine(linia1.GetLength());
            Console.WriteLine(linia2.GetLength());
        }
    }
}