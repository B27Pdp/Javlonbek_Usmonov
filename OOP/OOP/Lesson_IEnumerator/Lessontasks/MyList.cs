using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Lesson_IEnuriable.Lessontasks
{
    public class MyList : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            /*List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            yield return list[0];
            yield return list[1];
            yield return list[2];
            yield return list[3];*/

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                }
            }
        }
    }
}
