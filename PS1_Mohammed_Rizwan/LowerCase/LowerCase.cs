using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Rizwan Mohammed, CS 3500, u0746436

namespace LowerCase
{
    /// <summary>
    /// This program opens an input stream and lowercases the entered String
    /// </summary>
    class LowerCase
    {
        static void Main(string[] args)
        {
            //Try lowercasing, catch any unforeseen errors
            try
            {
                String line;
                while ((line = Console.ReadLine()) != null)
                {
                    //Remove any unncessary spaces
                    string a = String.Join(" ", line.Split(new string[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries));

                    //Print the lowecased string
                    Console.WriteLine(a.ToLower());
                }

            }
            //Catch any errors
            catch (Exception e)
            {
                Console.WriteLine("An error occurred. Please fix this error:" + e);
            }
           
        }
    }
}
