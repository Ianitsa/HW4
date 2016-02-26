using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem_1.Reverse_String
{
    class ReverseStr
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Please, enter a string: ");
            string input = Console.ReadLine();
            
            Console.WriteLine(string.Join("", input.Reverse()));
   
        }
    }
}
