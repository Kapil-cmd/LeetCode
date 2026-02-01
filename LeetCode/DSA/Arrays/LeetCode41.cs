
namespace LeetCode
{
    public class LeetCode41
    {
        public int FirstMissingPositive(int[] nums)
        {
            int n = nums.Length;

            if (!nums.Contains(1))
                return 1;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] <= 0 || nums[i] > n)
                    nums[i] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                int a = Math.Abs(nums[i]);
                if (a == n)
                    nums[0] = -Math.Abs(nums[0]);
                else
                    nums[a] = -Math.Abs(nums[a]); 
            }

            for (int i = 1; i < n; i++)
            {
                if (nums[i] > 0)
                    return i;
            }

            if (nums[0] > 0)
                return n;

            return n + 1;

        }
    }
}
