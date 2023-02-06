using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Delegate.Hometasks._2_masala
{
    delegate (int, int) MyDel(int[] arr); 
    internal class Printresult
    {
        public void MyPrint(MyDel del)
        {
            int[] arr =new int[10]
            {
                1,2,3,-4,5,6,7,8,454,-10
            };
            (int, int) n = del(arr);
            Console.WriteLine(n);
           
        }
    }
}
