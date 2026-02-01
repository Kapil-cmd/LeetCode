
namespace LeetCode
{
    public class LeetCode128
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;


            HashSet<int> result = new HashSet<int>();
            foreach (int num in nums)
            {
                result.Add(num);
            }

            int longest = 0;
            foreach (int x in result)
            {
                if (!result.Contains(x -1))
                {
                    int current = x;
                    int streak = 1;

                    while(result.Contains(current + 1))
                    {
                        current++;
                        streak++;
                    }

                    longest = Math.Max(longest, streak);
                }
            }
            return longest;
        }
    }
}
