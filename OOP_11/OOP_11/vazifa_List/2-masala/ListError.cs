using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*[1,2,3,4] deb yozmoqchi bo`ldik lekin xató yozib [1,2,2,4] deb yozdik. Bu yerda xató ketgan raqamni topadigan kod yozing.
 * Va bu masalani List dan foydalib yeching. 
 
[1,2,2,4] => 2 chiqishi kerak. (3 bolishi kerak edi 2 deb xató yozdik).*/
namespace OOP_11.vazifa_List._2_masala
{
    internal class ListError
    {
        public static void Error()
        {
            List<int> list1 = new List<int>
            {
                1,2,2,4
            };         
            for (int i = 1; i < list1.Count-1; i++)
            {
                if (list1[i + 1] - list1[i] != 1)
                {
                    Console.WriteLine(list1[i+1]);
                    break;
                }
            }
        }
        public static void GetError()
        {
            ListError.Error();
        }
    }
}
