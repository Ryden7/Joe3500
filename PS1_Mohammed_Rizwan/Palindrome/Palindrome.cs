using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    /// <summary>
    /// Written by Rizwan Mohammed for CS 3500
    /// This program takes an input string and determines whether or not its a Palindrome. If it is, it outputs the same String.
    /// </summary>
    class Palindrome
    {
        static void Main(string[] args)
        {
            //Catch any unforeseen errors
            try
            {
                String line;
                while ((line = Console.ReadLine()) != null)
                {
                    
                    string[] words = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                    if (isPalindrome(line) == true)
                        Console.WriteLine(line);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("An error occurred. Please fix this error:" + e);
            }
        }

        /// <summary>
        /// Method that determines if a String is a Palindrome
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Bool, true if it is a Palindrome</returns>
        public static bool isPalindrome(String input)
        {
            Char[] someString = input.ToArray();
            int min = 0;
            int max = input.Length - 1;

            while (min < max)
            {
                if (someString[min] != someString[max])
                {
                    return false;
                }

                min++;
                max--;
            }

            return true;

        }
    }
}
