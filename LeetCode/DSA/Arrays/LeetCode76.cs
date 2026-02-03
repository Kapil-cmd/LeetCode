
using System.Collections.Generic;

namespace LeetCode
{
    public class LeetCode76
    {
        public string MinWindow(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
                return "";

            var need = new Dictionary<char, int>();
            foreach (char c in t)
                need[c] = need.GetValueOrDefault(c,0) + 1;

            var window = new Dictionary<char, int>();

            int have = 0;
            int needCount = need.Count;

            int left = 0;
            int minLen = int.MaxValue;
            int start = 0;

            for(int right =0; right < s.Length; right++)
            {
                char c = s[right];
                window[c] = window.GetValueOrDefault(c,0) +1;

                if (need.ContainsKey(c) && window[c] == need[c])
                    have++;

                while (have == needCount)
                {
                    if (right - left + 1 < minLen)
                    {
                        minLen = right - left + 1;
                        start = left;
                    }

                    char leftChar = s[left];
                    window[leftChar]--;

                    if (need.ContainsKey(leftChar) && window[leftChar] < need[leftChar])
                        have--;

                    left++;
                }
            }
            return minLen == int.MaxValue?"":s.Substring(start, minLen);
        }
    }
}
