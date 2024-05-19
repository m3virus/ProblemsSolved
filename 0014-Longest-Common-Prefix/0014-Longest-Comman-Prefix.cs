using System.Text;

namespace Questions
{
    public class Code
    {
        public string LongestCommonPrefix(string[] strs)
        {
            bool check = false;
            var minValue = strs.MinBy(s => s.Length);
            do
            {
                if (minValue.Length == 0)
                {
                    check = false;
                    break;
                }

                if (Check(strs, minValue) == strs.Length)
                {
                    check = true;
                    break;
                }
                minValue = minValue.Remove(minValue.Length - 1);
            } while (minValue.Length != 0);
            if (check == true)
            {
                return minValue;
            }

            return "";

        }

        public int Check(string[] strs, string minValue)
        {
            int check = 0;
            string count;
            foreach (var counter in strs)
            {
                count = counter.Remove(minValue.Length);
                if (count == minValue)
                {
                    check++;
                }
            }
            return check;
        }
    }
}
