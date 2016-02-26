using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _06.Problem_6.Palindromes
{
    class Palindromes
    {

        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            var result = Regex.Matches(words, @"\w+").Cast<Match>()
                        .Select(m => m.Value)
                        .Where(w => String.Join("", w.Reverse()) == w).ToList();
            Console.WriteLine(string.Join(" ", result));  
        }
    }
}
