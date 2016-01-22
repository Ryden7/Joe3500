using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            String line;
            while ((line = Console.ReadLine()) != null)
            {

               // string a = String.Join(" ", line.Split(new string[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries));

                if (isPalindrome(line) == true)
                    Console.WriteLine(line);
            }
        }

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
