using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static public bool GetControlDigit(string pesel)
        {
            int[] scale = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int sum = 0;
            int control;

            for (int i = 0; i < pesel.Length - 1; i++)
            {
                sum += Convert.ToInt32(Char.GetNumericValue(pesel[i]) * scale[i]);
            }

            int modulo = sum % 10;

            control = 10 - modulo;
            
            if (control == 10)
            {
                control = 0;
            }

            if (control == Char.GetNumericValue(pesel[10]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            string pesel1 = "55030101230"; //poprawny
            string pesel2 = "55030101192"; //niepoprawny
            

           
            if(GetControlDigit(pesel2) == true)
            {
                Console.WriteLine("Pesel poprawny");
            }
            else
            {
                Console.WriteLine("Pesel niepoprawny");
            }
            
            
        }
    }
}