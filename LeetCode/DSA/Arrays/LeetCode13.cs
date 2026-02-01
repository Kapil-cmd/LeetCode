
using System.Data;

namespace LeetCode
{
    public class LeetCode13
    {
        public int RomanToInt(string s)
        {
            if(s == null || s.Length == 0)
            {
                return 0;
            }
            Dictionary<char,int> dic = new Dictionary<char,int>();
            dic.Add('I', 1);
            dic.Add('V', 5);
            dic.Add('X', 10);
            dic.Add('L', 50);
            dic.Add('C', 100);
            dic.Add('D', 500);
            dic.Add('M', 1000);

            int result = 0;
            int preValue =0;
            foreach(char c in s)
            {
                var value = dic[c];
                if(value > preValue)
                {
                    result += value - 2 * preValue;
                }
                else
                {
                    result += value;
                }
                preValue = value;
            }
            return result;
        }
    }
}
