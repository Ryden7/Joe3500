using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerCase
{
    class LowerCase
    {
        static void Main(string[] args)
        {
            String line;
            while ((line = Console.ReadLine()) != null)
            {

                string a = String.Join(" ", line.Split(new string[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries));

                Console.WriteLine(a.ToLower());
            }
        }
    }
}
