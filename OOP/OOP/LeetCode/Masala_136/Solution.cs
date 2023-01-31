namespace OOP.LeetCode.Masala_136
{
    public class Solution
    {
        public void SingleNumber(int[] nums)
        {
            //if (nums.Length == 1) return nums[0];
            List<int> list_nums = new List<int>();
            nums.ToList().Sort();
            List<int> counter = new List<int>();
            for (int i = 0; i < nums.ToList().Count; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
