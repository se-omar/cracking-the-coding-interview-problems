using System.Text;

namespace CTCIProblems.ArraysAndStrings;

public class StringCompression
{
    string Solution(string s)
    {
        int counter = 0;
        StringBuilder compressedStr = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            counter++;

            if (i+1 >= s.Length || s[i] != s[i + 1])
            {
                compressedStr.Append(s[i]).Append(counter);
                counter = 0;
            }
        }

        return compressedStr.ToString().Length < s.Length? compressedStr.ToString() : s;
    }
}