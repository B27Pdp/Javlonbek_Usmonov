using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Delegate.Hometasks._2_masala
{
    delegate (int,int) MinMax_delegate(List<int> list);
    internal class MinMan
    {
        public static void Start(List<int> list)
        {
            MinMax_delegate delegate0 = MinMax;
            Console.WriteLine(   delegate0(list));
        }
        private static (int, int) MinMax(List<int> list)
        {

            return (list.Min() , list.Max());
        }
    }
}
