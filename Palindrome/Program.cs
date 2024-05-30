using System;

namespace Palindrome
{
    class Program
    {
        static bool isPalindrome(string str)
        {

            if (str == null) throw new ArgumentNullException(nameof(str), "String não pode ser nula.");

            if (str.Length < 2) return false;

            string half1 = "";
            string half2 = "";

            if (str.Length % 2 == 0) //par
            {
                for (int i = 0; i < str.Length / 2; i++)
                {
                    half1 += str[i];
                }
                for (int i = str.Length - 1; i > str.Length / 2 - 1; i--)
                {
                    half2 += str[i];
                }
            }
            else //impar
            {
                for (int i = 0; i < str.Length / 2; i++)
                {
                    half1 += str[i];
                }
                for (int i = str.Length - 1; i > str.Length / 2; i--)
                {
                    half2 += str[i];
                }
            }

            if (half1.ToLower() == half2.ToLower()) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                bool result = false;
                try
                {
                    result = isPalindrome(arg);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine(arg + "->" + result);
            }
        }
    }
}
