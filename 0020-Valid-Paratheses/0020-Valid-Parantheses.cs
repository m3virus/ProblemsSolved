using System.Diagnostics.Tracing;
using System.Text;

namespace Questions
{
    public class Code
    {
        public bool IsValid(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (i+1>=s.Length)
                {
                    return false;
                }
                if (s[i] == '(' && s[i + 1] == ')')
                {
                    s = s.Replace("()", "");
                    if (s.Length == 0)
                    {
                        return true;
                    }

                    return IsValid(s);


                }
                if (s[i] == '[' && s[i + 1] == ']')
                {
                    s = s.Replace("[]", "");
                    if (s.Length == 0)
                    {
                        return true;
                    }

                    return IsValid(s);
                }
                if (s[i] == '{' && s[i + 1] == '}')
                {
                    s = s.Replace("{}", "");
                    if (s.Length == 0)
                    {
                        return true;
                    }

                    return IsValid(s);
                }
            }
            return false;
        }
    }
}
