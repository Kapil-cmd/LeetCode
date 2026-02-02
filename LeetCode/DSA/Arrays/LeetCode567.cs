

namespace LeetCode
{
    public class LeetCode567
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length) return false;

            Dictionary<char, int> s1Map = new();
            Dictionary<char, int> window = new();

            foreach (char c in s1)
                s1Map[c] = s1Map.GetValueOrDefault(c, 0) + 1;

            int left = 0;

            for (int right = 0; right < s2.Length; right++)
            {
                char ch = s2[right];
                window[ch] = window.GetValueOrDefault(ch, 0) + 1;

                if (right - left + 1 > s1.Length)
                {
                    char remove = s2[left];
                    window[remove]--;
                    if (window[remove] == 0)
                        window.Remove(remove);
                    left++;
                }

                if (AreEqual(s1Map, window))
                    return true;
            }

            return false;
        }

        bool AreEqual(Dictionary<char, int> a, Dictionary<char, int> b)
        {
            if (a.Count != b.Count) return false;

            foreach (var kv in a)
            {
                if (!b.ContainsKey(kv.Key) || b[kv.Key] != kv.Value)
                    return false;
            }
            return true;
        }
    }
}
