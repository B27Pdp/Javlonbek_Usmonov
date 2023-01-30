namespace OOP.Lesson_Generic.Lessontasks
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0) return 0;
            else if (nums.ToList().Contains(target))
            {
                int n = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == target)
                    {

                        n = i;
                        break;
                    }
                    else
                    {
                        n = nums.Length;
                    }
                }
                return n;
            }
            else
            {
                        int n = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (target > nums[i])
                    {
                        n = i + 1;
                    }
                }
                return n;
            }
        }
    }
}
