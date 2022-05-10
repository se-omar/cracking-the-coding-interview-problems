namespace CTCIProblems.ArraysAndStrings;

public class CheckPermutation
{
    // O(n) time, O(1) space.
    public bool Solution(string strA, string strB)
    {
        int[] occurs = new int[128];
        
        for (int i = 0; i < strA.Length; i++)
        {
            int charVal = strA[i];
            occurs[charVal]++;
        }
        
        for (int i = 0; i < strB.Length; i++)
        {
            int charVal = strB[i];
            occurs[charVal]--;
            if (occurs[charVal] < 0) return false;
        }

        return true;
    }
}