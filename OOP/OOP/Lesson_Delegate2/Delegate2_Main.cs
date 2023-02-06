using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Lesson_Delegate2.Hometasks;
using OOP.Lesson_Delegate2.Lessontasks;
using OOP.Lesson_Event.Lessontasks;

namespace OOP.Lesson_Event
{
    internal class Delegate2_Main
    {
        public static void Mainn()
        {
            /*ActionClass action = new();
            action.Start();
            FuncClass objfunc=new FuncClass();
            objfunc.Start();*/
            /*Pridikates obj=new Pridikates();
            obj.Start(10);*/
            /*Delegate1 w = new Delegate1();
            w.Start(w.Boool);*/
            /*Delegate2 obj = new Delegate2();
            obj.Delegate2_Run(obj.Delegate2_Log);*/
            /*Action1 a1= new Action1();
            a1.Stop();*/
            Func1 obj = new Func1();
            obj.Func1_Run(new List<int> { 1, 2,3,4,5,6 });
            Func2 obj1 = new Func2();
            obj1.Func2_Run();
        }
    }
}
