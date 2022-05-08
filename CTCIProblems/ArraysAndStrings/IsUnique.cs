namespace CTCIProblems.ArraysAndStrings;

public class IsUnique
{
    //this assumes 128 character ascii
    //O(n) time, O(1) space.
    public bool Solution(string s)
    {
        if (s.Length > 128) return false;
        bool[] occurrences = new bool[128];
        for (int i = 0; i < s.Length; i++)
        {
            if (occurrences[s[i]]) return false;
                occurrences[s[i]] = true;
        }

        return true;

    }

    public bool BruteforceSolution(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + 1; j < s.Length; j++)
            {
                if (s[i] == s[j]) return false;
            }
        }
        
        return true;
    }
}