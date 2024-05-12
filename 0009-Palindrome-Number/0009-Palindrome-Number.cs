namespace Questions
{
    public class Code
    {
        public bool IsPalindrome(int x)
        {
            var number = Convert.ToString(x);

            if (number.Length % 2 == 0)
            {
                for (var a = 0; a < number.Length / 2; a++)
                {
                    if (number[a] != number[number.Length - (1 + a)])
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < (number.Length - 1) / 2; i++)
                {
                    if (number[i] != number[number.Length - (1 + i)])
                    {
                        return false;
                    }
                }
            }

            return true;

        }
    }
}
