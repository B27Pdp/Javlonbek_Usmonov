using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_IEnumerator.Hometasks._2_masala
{
    public class Numbers
    {
        List<int> numbers = new List<int>();    
        public int this[int index]
        {
            get
            {
                return numbers[index];
            }
            set
            {
                numbers[index] = value;
            }
        }
        public void Random_Num()
        {
            Random random= new Random();
            for (int i = 0; i < 50; i++)
            {
                numbers.Add(random.Next(0,100));
                Console.WriteLine($"{i+1} -> "+numbers[i]);
            }
        }
    }
}
