using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_11
{
    public class List
    {
        public static void Do()
        {
            ArrayList arr = new();
            arr.Add(1);
            arr.Add(2);
            arr.Add("Javlon");
            arr.Add(4);
            arr.Add(5);

            //arr.AddRange(new[] { 2,3,4,5});

            Console.WriteLine("INDEX-> " + arr.IndexOf(4));
            arr.Insert(2, new int[] { 2, 3, 4, 5 });
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public static void StartArrayList()
        {
            Do();
        }

    }
}
