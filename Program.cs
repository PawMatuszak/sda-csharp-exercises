using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static public int Power(int n, int power)
        {
            int result = n;
            for (int i = 1; i < power; i++)
            {
                result = result * n;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Jakiej liczby chcesz poznać potęgę Poszukiwaczu wiedzy");
            int master = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"i do której potęgi chcesz podnieść {master} ?");
            int power = Convert.ToInt32(Console.ReadLine());
            


            if (power < 0)
            {
                Console.WriteLine("Tak się chyba nie da co?");
            }
            else
            {
                Console.WriteLine($" Twoja odpowiedź to: {Power(master, power)}");
            }
            
        }
    }
}
