using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Event.Lessontasks
{
    internal class FuncClass
    {
        public void Start()
        {
            Func<int, bool> func = n =>
            {
                if (n > 0)
                {
                    return true;
                }
                return false;
            };
            Console.WriteLine(   func(-8));
        }
        
        
    }
}
