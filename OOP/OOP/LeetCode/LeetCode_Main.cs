using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.LeetCode.Masala_136;

namespace OOP.LeetCode
{
    public class LeetCode_Main
    {
        public static void Mainn()
        {
            /*nums = [4, 1, 2, 1, 2]
            Output: 4*/
            Solution obj = new Solution();
            //1 1 2 2 4
            //Console.WriteLine(obj.SingleNumber(new int[] { 4, 1, 2, 1, 2,2 }));
            obj.SingleNumber(new int[] { 4, 1, 2, 1, 2, 2 });
        }
    }
}
