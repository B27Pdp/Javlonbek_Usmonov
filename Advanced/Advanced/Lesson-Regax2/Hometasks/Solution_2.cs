using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.Lesson_Regax2.Hometasks
{
    internal class Solution_2
    {
        public static string ReverseStr(string s, int k)
        {
            string str = "";
            string s1 = "";

            for (int i = 0; i < s.Length-k; i+=k)
            {
                s1 = s.Substring(i, k);
                string s2 = "";
                for (int j = s1.Length-1; j >=0; j++)
                {
                    s2 += s1[i];
                }
                str += s2;
                str += s.Substring(i + k, k);
                i=i+ k;
                Console.WriteLine("dfhreytr");
                if(i<s.Length) 
                {
                    break;
                }
            }
            Console.WriteLine(  "ferywrery");
            return str;
        }
    }
}
