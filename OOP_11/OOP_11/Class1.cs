using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_11
{
    internal class Class1
    {
        public int[] SortArrayByParity(int[] nums)
        {
            List<int> list_nums = new List<int>();
            list_nums=nums.ToList();
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();
            foreach (var item in list_nums)
            {
                if(item%2==0)
                {
                    list1.Add(item);
                }
                else if(item%2==1)
                {
                    list2.Add(item);
                }
            }
            int min = 0;
            if(list1.Count>list2.Count)
            {
                min = list2.Count;
            }
            else
            {
                min = list1.Count;
            }
            for (int i = 0; i < min; i++)
            {
                list3.Add(list1[i]);
                list3.Add(list2[i]);
            }
            
            
            return list3.ToArray();
        }
    }
}
