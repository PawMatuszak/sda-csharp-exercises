using System;

namespace sda_csharp_exercises
{
    class Program
    {
        public static bool PasswordChecker(string password)
        {
            bool MinLength = password.Length >= 6;
            bool hasCapitalLetter = false;
            bool hasSmallLetter = false;
            bool hasNumber = false;
            bool hasSpecialSign = false;
            const string SPECIAL_CHARACTERS = "&*$#";

            foreach (char character in password.ToCharArray())
            {
                if (Char.IsUpper(character))
                {
                    hasCapitalLetter = true;
                }
                if (Char.IsLower(character))
                {
                    hasSmallLetter = true;
                }
                if (Char.IsDigit(character))
                {
                    hasNumber = true;
                }
                if (SPECIAL_CHARACTERS.Contains(character))
                {
                    hasSpecialSign = true;
                }
            }
            return MinLength && hasCapitalLetter && hasSmallLetter && hasNumber && hasSpecialSign;

        }

        static void Main(string[] args)
        {


            Console.WriteLine("Podaj swoje hasło");
            string password = Console.ReadLine();

                if ( PasswordChecker(password) == true)
            {
                Console.WriteLine("Brawo Twoje hasło jest idealne");
            }else
            {
                Console.WriteLine("Twoje hasło nie jest dosć silne");
            }

            

        }
    }
}
