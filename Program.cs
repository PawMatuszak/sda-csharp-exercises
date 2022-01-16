using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile sztuk zamierzasz kupić?");
            int quanity = Convert.ToInt32(Console.ReadLine());
            int price = 5;


            for (int i = 1; i<=quanity; i++)
            {
                Console.WriteLine($"Liczba sztuk: {i}. Łączna cena: {price} zł.");
                price = price + 5;
            }
        }
    }
}
