using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void wypisz_ciag(int n, int a1, int r)
        {
            int result = a1;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{result}, ");
                result += r;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj pierwszy element Twojego ciągu");
            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj jego długość");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Podaj jego różnicę");
            int r = Convert.ToInt32(Console.ReadLine());


            wypisz_ciag(n, a1, r);
        }
    }
}