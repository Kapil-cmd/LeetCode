
namespace LeetCode
{
    public class LetetCode303
    {
        private int[] prefix;
        public class NumArray
        {
            private int[] prefix;

            public NumArray(int[] nums)
            {
                prefix = new int[nums.Length];
                prefix[0] = nums[0];

                for (int i = 1; i < nums.Length; i++)
                {
                    prefix[i] = prefix[i - 1] + nums[i];
                }
            }

            public int SumRange(int left, int right)
            {
                if (left == 0)
                    return prefix[right];

                return prefix[right] - prefix[left - 1];
            }
        }

    }
}
