using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringUtility;

namespace StringUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a conversion using C# (h = hours, m = minutes, s = seconds):");
            // Enter the time you want to convert here in the parenthesis
            Console.WriteLine(StringUtility.ConvertStringToMilliseconds("2h"));

            Console.WriteLine("");
            Console.WriteLine("This is a conversion using Regex (h = hours, m = minutes, s = seconds):");
            // Enter the time you want to convert here in the parenthesis
            Console.WriteLine(StringUtilityRegex.ConvertStringToMilliseconds("10h"));
            Console.ReadLine();
        }
    }
}
