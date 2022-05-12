namespace CTCIProblems.ArraysAndStrings;

public class URLify
{
    //replace from start solution
    public char[] Solution1(string s, int trueLen)
    {
        char[] chars = new char[s.Length];
        int k = 0;
        for (int i = 0; i < trueLen; i++)
        {
            if (s[i] == ' ')
            {
                chars[k] = '%';
                chars[k + 1] = '2';
                chars[k + 2] = '0';
                k += 3;
            }

            else chars[k++] = s[i];
        }

        return chars;
    }

    //replace from end solution
    public char[] Solution2(char[] s, int trueLen)
    {
        int requiredLen = s.Length;
        for (int i = trueLen - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                s[requiredLen - 1] = '0';
                s[requiredLen - 2] = '2';
                s[requiredLen - 3] = '%';
                requiredLen -= 3;
            }
            else
            {
                s[requiredLen - 1] = s[i];
                requiredLen--;
            }
        }

        return s;
    }
}