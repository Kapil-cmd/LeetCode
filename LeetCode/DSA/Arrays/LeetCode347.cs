namespace LeetCode
{
    public class LeetCode347
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            if (nums == null || k == 0)
            {
                return null;
            }
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                map[num] = map.GetValueOrDefault(num, 0) + 1;
            }

            PriorityQueue<int,int> heap = new PriorityQueue<int, int> ();

            foreach(var kv in map)
            {
                heap.Enqueue(kv.Key,-kv.Value);
            }
            int[] result = new int[k];

            for (int i = 0; i < k; i++)
            {
                result[i] = heap.Dequeue();
            }

            return result;


        }
    }
}
