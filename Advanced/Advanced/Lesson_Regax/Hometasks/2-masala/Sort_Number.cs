using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Advanced.Lesson_Regax.Hometasks._2_masala
{
    internal class Sort_Number
    {
        public static void Sort(string str) 
        {
            MatchCollection matches = Regex.Matches(str, @"\d");
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
