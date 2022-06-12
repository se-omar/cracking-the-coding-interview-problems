using System.Text;

namespace CTCIProblems.ArraysAndStrings;
// time O(N), space O(1)
public class StringRotation
{
    public bool Solution(string s1, string s2)
    {
        string s1s1 = s1 + s1;
        if (s1.Length != s2.Length || s1.Length == 0 || s2.Length == 0) return false;
        return s1s1.Contains(s2);
    }
}