using System.Runtime.Intrinsics.Arm;

namespace CTCIProblems.ArraysAndStrings;

public class OneAway
{
    public bool Solution(string s1, string s2)
    {
        if (s1 == s2) return true;
        if (s1.Length == s2.Length) return CheckReplace(s1, s2);
        if (s1.Length > s2.Length) return CheckInsertRemove(s1, s2);
        return CheckInsertRemove(s2, s1);
    }

    bool CheckReplace(string s1, string s2)
    {
        bool flag = false;
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                if (flag) return false;
                flag = true;
            }
        }

        return true;
    }

    bool CheckInsertRemove(string longS, string shortS)
    {
        int longIndex = 0;
        int shortIndex = 0;
        while (longIndex < longS.Length && shortIndex < shortS.Length)
        {
            if (longS[longIndex] != shortS[shortIndex])
            {
                if (longIndex != shortIndex) return false;
                longIndex++;
            }
            else
            {
                longIndex++;
                shortIndex++;
            }
        }

        return true;
    }


}