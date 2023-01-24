using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Ranglar uchun enum yarating hamda quyidagicha informatsiyalarni console ga chiqaring.
RED at index 0
GREEN at index 1
BLUE at index 2 */
namespace OOP_10.uyga_vazifa_enum._2_masala_sayt
{
    internal class Color
    {
        public static void GetColorIndex()
        {
            Console.WriteLine((Colors)0+ " at index 0");
            Console.WriteLine((Colors)1+ " at index 1");
            Console.WriteLine((Colors)2+ " at index 2");
        }
    }
    enum Colors
    {
        Red,
        Green,
        Blue,
    }
}
