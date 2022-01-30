using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Point coordinates = new Point(0, 0);

            coordinates.Move(1, 8);
            coordinates.Print();

        }
    }
}
