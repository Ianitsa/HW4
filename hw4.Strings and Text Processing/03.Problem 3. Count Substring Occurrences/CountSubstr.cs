using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problem_3.Count_Substring_Occurrences
{
    class CountSubstr
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string subString = Console.ReadLine();

            int count = text.Select((c, i) => text.Substring(i)).Count(x => x.StartsWith(subString, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(count);
        }
    }
}
