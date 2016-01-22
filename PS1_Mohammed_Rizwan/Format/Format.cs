using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    class Format
    {
        static void Main(string[] args)
        {
            String line;
            int spaceLength;
            Int32.TryParse(args[0], out spaceLength);

            if (spaceLength == 0)
                spaceLength = 1;

            while ((line = Console.ReadLine()) != null)
            {
                //   string[] words = line.Split({' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
                string[] words = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);


                int counter = 0;

                for(int i = 0; i < words.Length; i++)
                {
                    Console.Write(words[i] + " ");
                    counter++;

                    if (counter == spaceLength)
                    {
                        Console.Write("\n");
                        counter = 0;
                    }


                }
            }
        }
    }
}
