using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*Ismlar to'plami berilgan. 
 * Regex yordamida to'plam ichidan bosh harfi 'S' bilan boshlanuvchi ismlarni ajratib beruvchi dastur tuzing*/
namespace Advanced.Lesson_Regax.Hometasks._1_masala
{
    internal class Names
    {
        public List<string> names= new();
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }

        public void Sorted()
        {
            string pottern = $"^S[a-z]+$";
            for (int i = 0; i < names.Count; i++)
            {
                if (Regex.IsMatch(names[i], pottern))
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
        public Names(List<string> names)
        {
            this.names = names;
        }
    }
}
