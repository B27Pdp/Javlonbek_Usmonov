using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Delegate.Hometasks._3_masala
{
    delegate (int, int) MinMax(List<int> list);
    internal class min
    {
        public void Start(List<int> list)
        {
            MinMax del = Min_Max;
            Console.WriteLine(del(list));
        }
        public (int, int) Min_Max(List<int> list)
        {
            return (list.Min(), list.Max());
        }
    }
}
