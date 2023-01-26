using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP_11.vazifa_List
{
    internal class Solution
    {
        /*public bool IsPalindrome(ListNode head)
        {
            for (int i = 0, i< head.Count, i++)
            {
                if (head[i] == head.Count - 1)
            }
        }*/
        
       

        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            List<string> list_1 = new List<string>();
            List<string> list_2 = new List<string>();
            list_1=list1.ToList();
            list_2=list2.ToList();
            List<string> list_item = new List<string>();
            List<string> list_result = new List<string>();
            List<int> list_index = new List<int>();
            int min =int.MaxValue;
            foreach (var item in list_1)
            {
                if (list_2.Contains(item))
                {
                    int sum = list_1.IndexOf(item) + list_2.IndexOf(item);
                    list_item.Add(item);
                    list_index.Add(sum);
                    if (min > sum)
                    {
                        min = sum;
                    }
                }
            }
            for (int i = 0; i < list_item.Count; i++)
            {
                if (list_index[i] == min)
                {
                    list_result.Add(list_item[i]);
                }
            }
            return list_result.ToArray();
        }

    }
}
