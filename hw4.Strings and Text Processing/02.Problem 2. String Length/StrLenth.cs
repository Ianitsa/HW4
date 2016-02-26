using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem_2.String_Length
{
    class StrLenth
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Please, enter a string:");
            string input = Console.ReadLine().Trim();
           
            string output = input.Length > 20 ? input.Substring(0, 20) : input.PadRight(20, '*');
           
            Console.WriteLine(output);
        }
    }
}
