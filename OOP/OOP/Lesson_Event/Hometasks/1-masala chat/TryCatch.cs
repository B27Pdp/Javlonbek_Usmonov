using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Event.Hometasks
{
    internal class TryCatch
    {
        public void Run()
        {
                menyu:
            try
            {
                int n = int.Parse(Console.ReadLine());
            }
            catch 
            {
                goto menyu;
            }
        }

    }
}
