

namespace LeetCode
{
    public class LeetCode217
    {
        public bool Duplicates(int[] nums)
        {
            var hash = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {


                if (hash.ContainsKey(nums[i]))
                {
                    return true;
                }
                else
                {
                    hash.Add(nums[i], i);
                }
            }
            return false;

        }



    }
}
