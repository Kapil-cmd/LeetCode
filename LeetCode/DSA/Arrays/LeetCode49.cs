using System.Text;

namespace LeetCode
{
    public class LeetCode49
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs.Length == 0)
            {
                return new List<IList<string>>();
            }

            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            int[] count = new int[26];

            foreach (string str in strs)
            {
                Array.Fill(count, 0);

                foreach (char c in str)
                {
                    count[c - 'a']++;
                }

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 26; i++)
                {
                    sb.Append('#');
                    sb.Append(count[i]);
                }

                string key = sb.ToString();

                if (!map.ContainsKey(key))
                {
                    map[key] = new List<string>();
                }

                map[key].Add(str);
            }

            return map.Values.Cast<IList<string>>().ToList();
        }
    }
}
