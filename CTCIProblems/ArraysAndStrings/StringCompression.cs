using System.Text;

namespace CTCIProblems.ArraysAndStrings;

public class StringCompression
{
    string Solution(string s)
    {
        int counter = 0;
        int comparer = 0;
        StringBuilder ans = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[comparer] == s[i]) counter++;

            if (s[comparer] != s[i] || i + 1 >= s.Length)
            {
                if (counter > 0)
                {
                    ans.Append(s[comparer]);
                    ans.Append(counter);
                }

                comparer = i;
                counter = 1;
            }
        }

        return ans.ToString();
    }
}