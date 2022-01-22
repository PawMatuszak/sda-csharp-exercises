using System;

namespace sda_csharp_exercises
{  
        class Program
        {

        static void Main(string[] args)

        {
            Console.WriteLine("Podaj treść do zakodowania lub odkodowania");
            string message = Console.ReadLine();


            Console.WriteLine($"Wiadomość zakodowana to:{Kodowanko(message)} Natomiast po dokodowaniu: {Dekodowanko(message)} ");

        }


        public static string Kodowanko(string input)
            {
                char[] leetLetters = { '4', '3', '1', '0', '$', '7' };
                char[] neutralLetters = { 'a', 'e', 'i', 'o', 's', 't' };

                input = input.ToLower();

                string output = input;

                for (int i = 0; i < neutralLetters.Length; i++)
                {
                    output = output.Replace(neutralLetters[i], leetLetters[i]);
                }

                return output;
            }

                 public static string Dekodowanko(string input)
            {
                char[] leetLetters = { '4', '3', '1', '0', '$', '7' };
                char[] neutralLetters = { 'a', 'e', 'i', 'o', 's', 't' };

                input = input.ToLower();

                string output = input;

                for (int i = 0; i < leetLetters.Length; i++)
                {
                    output = output.Replace(leetLetters[i], neutralLetters[i]);
                }

                return output;
            }

            
        }
    }
