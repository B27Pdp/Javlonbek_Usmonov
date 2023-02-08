using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Advanced.Lesson_Regax.Lesson_Regax2.Hometasks
{
    internal class Regax_Excample
    {
        public static void Run_PhoneNumber()
        {
            string? pattern = @"(\+?998[0-9]{2})?[0-9]{7}";
            Console.WriteLine(Regex.IsMatch("903409342",pattern));
        }
    }
}
