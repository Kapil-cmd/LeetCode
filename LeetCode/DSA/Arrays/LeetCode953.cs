namespace LeetCode
{
    public class LeetCode953
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            if (string.IsNullOrWhiteSpace(order))
                return false;

            Dictionary<char, int> mapping = new Dictionary<char, int>();
            for (int i = 0; i < order.Length; i++)
            {
                mapping[order[i]] = i;
            }

            for (int i = 0; i < words.Length - 1; i++)
            {
                string word1 = words[i];
                string word2 = words[i + 1];

                int minLength = Math.Min(word1.Length, word2.Length);
                bool foundDifference = false;

                for (int j = 0; j < minLength; j++)
                {
                    int c1 = mapping[word1[j]];
                    int c2 = mapping[word2[j]];

                    if (c1 < c2)
                    {
                        foundDifference = true;
                        break;
                    }
                    else if (c1 > c2)
                    {
                        return false;
                    }
                }

                if (!foundDifference && word1.Length > word2.Length)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
