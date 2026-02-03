

namespace LeetCode
{
    public class LeetCode424
    {
        public int CharacterReplacement(string s, int k)
        {
            int[] occurance = new int[26];
            int left = 0;
            int ans = 0;
            int maxOccurance = 0;

            for (int right = 0; right < s.Length; right++)
            {
                int index = s[right] - 'A';
                occurance[index]++;

                maxOccurance = Math.Max(maxOccurance, occurance[index]);


                while (right - left + 1 - maxOccurance > k)
                {
                    occurance[s[left] - 'A']--;
                    left++;
                }

                ans = Math.Max(ans, right - left + 1);
            }

            return ans;
        }
    }
}
