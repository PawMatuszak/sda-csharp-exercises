using System;
using System.Linq;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ile liczb chcesz wprowadzić?");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i <= n-1; i++)
            {
                Console.WriteLine($"Podaj " +(i+1) + " wartość tablicy");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            PrintNumbers(numbers);
        }

        public static void PrintNumbers(int[] numbers)
        {
           
            int[] newNumbers = new int[numbers.Length];

            for (int i = 0; i < newNumbers.Length; i++)
            {
                newNumbers[i] = -1;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!newNumbers.Contains(numbers[i]))
                {
                    newNumbers[i] = numbers[i];
                }
            }

            
            foreach (var number in newNumbers)
            {
                if (number >= 0)
                {
                    Console.Write($"{number} ");
                }
            }
        }

    }
}
