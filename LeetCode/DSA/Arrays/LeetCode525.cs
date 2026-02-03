
namespace LeetCode
{
    public class LeetCode525
    {
        public int FindMaxLength(int[] nums)
        {
            int length = nums.Length;

            var dic = new Dictionary<int, int>(2);
            int total = 0;
            for (int i = 0; i < length; i++)
            {
                if (nums[i] == 0)
                    total = total - 1;
                else
                    total = total + 1;
            }
            return total;
        }
    }
}
