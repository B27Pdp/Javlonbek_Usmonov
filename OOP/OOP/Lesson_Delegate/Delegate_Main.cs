using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Lesson_Delegate.Hometasks._1_masala;
using OOP.Lesson_Delegate.Hometasks._2_masala;
using OOP.Lesson_Delegate.Lessontasks;

namespace OOP.Lesson_Delegate
{
    internal class Delegate_Main
    {
        public static void Mainn()
        {
            /*Class1 obj =new Class1();
            obj.Start();*/
            //Math_m.Start(10, 6);
            //MinMan.Start(new List<int> { 1, 2, 3,-8, 4, 5, 68, 6, 7, 8, });
            /*min obj = new min();
            obj.Start(new List<int> { 1, -2, 3,9 });*/
            Logika obj1= new Logika();
            Printresult obj2= new Printresult();
            obj2.MyPrint(obj1.nx);
        }
    }
}
