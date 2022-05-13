namespace CTCIProblems.ArraysAndStrings;

public class PalindromePermutation
{
    //O(N) time, O(1) space. 
    public bool Solution(string s)
    {
        bool oddFound = false;
        int[] occurs = new int[26];
        
        for (int i = 0; i < s.Length; i++)
        {
            int charVal = s[i];
            occurs[charVal - 'a']++;
        }

        for (int i = 0; i < occurs.Length; i++)
        {
            if (occurs[i] != 0)
            {
                if (occurs[i] % 2 != 0)
                {
                    if (oddFound) return false;
                    oddFound = true;
                }
            }
        }

        return true;
    }
}