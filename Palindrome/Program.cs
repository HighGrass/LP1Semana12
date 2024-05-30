using System;

namespace Palindrome
{
    class Program
    {
        static bool isPalindrome(string str, out bool result)
        {
            result = false;

            if (str.Length < 2) return result = false;

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

            if (half1.ToLower() == half2.ToLower()) return result = true;
            else return result = false;
        }
        static void Main(string[] args)
        {
            string str = "Ana";
            string text = "";

            bool result = false;
            isPalindrome(str, out result);

            if (!result) text = "not a ";

            Console.WriteLine(str + " is " + text + "Palindrome!");

        }
    }
}
