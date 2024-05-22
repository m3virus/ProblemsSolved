namespace Questions
{
    public class Code
    {
        public int RomanToInt(string s)
        {
            s = s.ToUpper();
            var sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I')
                {
                    if (i + 1 < s.Length)
                    {

                        if (s[i + 1] == 'V')
                        {
                            sum += 4;
                            i++;
                        }
                        else if (s[i + 1] == 'X')
                        {
                            sum += 9;
                            i++;
                        }
                        else
                        {
                            sum += 1;
                        }
                    }
                    else
                    {
                        sum += 1;
                    }
                }
                else if (s[i] == 'X')
                {
                    if (i + 1 < s.Length)
                    {

                        if (s[i + 1] == 'L')
                        {
                            sum += 40;
                            i++;
                        }
                        else if (s[i + 1] == 'C')
                        {
                            sum += 90;
                            i++;
                        }
                        else
                        {
                            sum += 10;
                        }
                    }
                    else
                    {
                        sum += 10;
                    }
                }
                else if (s[i] == 'C')
                {
                    if (i + 1 < s.Length)
                    {

                        if (s[i + 1] == 'D')
                        {
                            sum += 400;
                            i ++;
                        }
                        else if (s[i + 1] == 'M')
                        {
                            sum += 900;
                            i ++;
                        }
                        else
                        {
                            sum += 100;
                        }
                    }
                    else
                    {
                        sum += 100;
                    }
                }
                else if (s[i] == 'M')
                {

                    sum += 1000;

                }
                else if (s[i] == 'D')
                {

                    sum += 500;

                }
                else if (s[i] == 'L')
                {

                    sum += 50;

                }
                else if (s[i] == 'V')
                {
                    sum += 5;
                }
            }
            return sum;
        }
    }
}
