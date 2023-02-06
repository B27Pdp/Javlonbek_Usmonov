using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Delegate2.Hometasks
{
    delegate List<int> MyDelegate2(List<int> list);
    internal class Delegate2
    {
        public List<int> list = new List<int>();
        public int this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }
        public void Delegate2_Run(MyDelegate2 delegate2)
        {
            List<int> lists = new List<int>();
            List<int> list = new List<int>()
            {
                1,2,3,4,5,6
            };
            lists=delegate2(list);

            foreach (var item in delegate2(lists))
            {
                Console.WriteLine(item);
            }
        }
        public List<int> Delegate2_Log(List<int> lists)
        {
            
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    lists.Add(i);
                }
            }
            return lists;
        }
    }
}
