
namespace LeetCode
{
    public class TwoSum
    {
        //nums:[15,7,2,11]  Target:9
        public int[] TwoSums(int[] nums, int target)
        {
            Dictionary<int,int> map = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                int comlpemet = target - nums[i];
                if(map.ContainsKey(comlpemet))
                {
                    return new int[] { map[comlpemet], i };
                }
                if (!map.ContainsKey(nums[i])) 
                    map.Add(nums[i], i);
            }
            return new int[] {};      
        }

    }
}
