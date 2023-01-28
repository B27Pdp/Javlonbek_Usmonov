using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Lesson_Taple_.Lessontasks;
using OOP.Lesson_Taple_Nullable.Hometasks.Masala;
using OOP.Lesson_Taple_Nullable.Hometasks.Proyekt;
using OOP.Lesson_Taple_Nullable.Lessontasks;

namespace OOP.Lesson_Taple_Nullable
{
    public class Tuple_Main
    {
        public static void Mainn()
        {
            //Tuplle.Tuplee();
            //Nullable_task.Nullablee();

            /*Generic<int,MyClass,MyClass> generic = new(5,6);
            generic.Add(5, 5);*/
            /*Generic_3<int> obj= new Generic_3<int>();
            obj.Oxirgi();*/
            //Dictionary_3.PrintDictionary();
            TripleDictionary<int,string,double> obj =new TripleDictionary<int,string,double>();
            obj.OrderBy(new List<int> { 5, 9, 4, 1, 2, 3 });
            obj.OrderByDesc(new List<int> { 5, 9, 4, 1, 2, 3 });
            
        }
    }
}
