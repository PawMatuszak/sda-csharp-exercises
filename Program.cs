using System;

namespace sda_csharp_exercises
{
    class Program
    {
        public static void makeTriangle(int lenght, string sign)
        {
            for(int i = 0 ; i<lenght ; i++)
            {
                for (int j = 0 ; j<=i ; j++)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();
            }

            for (int i = lenght - 1 ; i>0 ; i--)
            {
                for (int j = i; j>0; j--)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Podaj najwyższy punkt piramidy");
            int lenght = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj swój znak");
            string sign = Console.ReadLine();

            Console.WriteLine();

            makeTriangle(lenght, sign);

        }
    }
}
