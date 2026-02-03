
namespace LeetCode
{
    public class LeetCode239
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums.Length == 0 || k == 0)
                return Array.Empty<int>();

            int n = nums.Length;
            int[] result = new int[n - k + 1];
            LinkedList<int> deque = new(); 
            for (int i = 0; i < n; i++)
            {
                if (deque.Count > 0 && deque.First.Value <= i - k)
                    deque.RemoveFirst();

                while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
                    deque.RemoveLast();

                deque.AddLast(i);

                if (i >= k - 1)
                    result[i - k + 1] = nums[deque.First.Value];
            }

            return result;
        }

    }
}
