using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Delegate.Lessontasks
{
    delegate void Class2_Delegate();
    internal class Class2
    {
        public void Add()
        {
            Console.WriteLine("9 + 5 = 14");
            Class1 obj1= new Class1();
            Class2_Delegate _Delegate = obj1.Start;
            _Delegate();
        }
    }
}
