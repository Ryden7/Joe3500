using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{

    /// <summary>
    /// Written by Rizwan Mohammed for CS 3500
    /// This program takes an int command line parameter and formats that many words per line from a written setence
    /// </summary>
    class Format
    {

        static void Main(string[] args)
        {
            //In case we come across any errors, use a try-catch to catch them.
            try
            {
                String line;
                int spaceLength;
                int counter = 0;


                Int32.TryParse(args[0], out spaceLength);

                if (spaceLength <= 0)
                    spaceLength = 1;

                //Runs until we close the input stream
                while ((line = Console.ReadLine()) != null)
                {
                    //Removes any amount white spaces
                    string[] words = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);



                    for (int i = 0; i < words.Length; i++)
                    {
                        Console.Write(words[i] + " ");
                        counter++;

                        //Adds a new line if we have hit the desired word length
                        if (counter == spaceLength)
                        {
                            Console.Write("\n");
                            counter = 0;
                        }


                    }
                    //Space to increase clarity
                    Console.WriteLine("\n");

                }
            }

            //Catch any unforeseen errors with the command line
            catch (Exception e)
            {
                Console.WriteLine("An error occurred. Please fix this error:" + e);
            }
        }
    }
}
