using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_Taple_Nullable.Hometasks.Masala
{
    public class Dictionary_3
    {
        public static void PrintDictionary()
        {
            Dictionary<int, int> map1 = new Dictionary<int, int>();
            Dictionary<string, string> map2 = new Dictionary<string, string>();
            map1.Add(1, 111);
            map1.Add(2, 222);
            map2.Add("name", "Tom");
            map2.Add("age", "25");
            Console.WriteLine("Key : 1 , Value : " + map1[1]);
            Console.WriteLine();
            Console.WriteLine("Key : 2 , Value : " + map1[2]);
            Console.WriteLine();
            Console.WriteLine("Key : name , Value : " + map2["name"]);
            Console.WriteLine();
            Console.WriteLine("Key : age , Value : " + map2["age"]);
        }
    }
}
