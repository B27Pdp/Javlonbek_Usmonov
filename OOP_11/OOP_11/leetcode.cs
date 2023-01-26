using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_11
{
    internal class leetcode
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int>list = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j] && list.Contains(nums1[i])==false)
                    {
                        list.Add(nums1[i]);
                    }
                }
            }
            return list.ToArray();
        }
    }
}
