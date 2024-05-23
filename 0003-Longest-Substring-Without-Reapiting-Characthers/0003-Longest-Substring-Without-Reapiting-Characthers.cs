using System.Diagnostics.Tracing;
using System.Text;

namespace Questions
{
    public class Code
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            var substringList = new List<string>();
            while (s.Length > 0)
            {
                var subString = SubStringBuilder(s);
                substringList.Add(subString);
                s = s.Remove(0, 1);
            }

            return substringList.Select(x => x.Length ).Max();

        }

        public string SubStringBuilder(string s)
        {
            string builder = "";
            foreach (var counter in s)
            {
                if (!builder.Contains(counter))
                {
                    builder += counter;
                }
                else
                {
                    break;
                }
            }
            return  builder;
        }
    }
}
