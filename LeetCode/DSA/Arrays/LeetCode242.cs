

namespace LeetCode
{
    public class LeetCode242
    {
        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }
            int coun1 = 0;
            int coun2 = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char element = s[i];
                foreach (char elementT in s)
                {
                    if (element == elementT)
                    {
                        coun1++;
                    }
                }
                if (!t.Contains(s[i]))
                {

                    return false;
                }
                if (t.Contains(s[i]))
                {
                    foreach (char elementS in t)
                    {
                        if (element == elementS)
                        {
                            coun2++;
                        }
                    }
                }
                else
                {
                    return false;
                }
                if (coun1 != coun2)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
