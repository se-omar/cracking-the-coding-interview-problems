namespace CTCIProblems.ArraysAndStrings;

public class RotateMatrix
{
    public int[][] Solution(int[][] sourceAr)
    {
        int left = 0;
        int right = sourceAr.Length - 1;

        while (left < right)
        {
            //loop number of layers (n/2)
            for (int i = 0; i < right - left; i++)
            {
                int top = left;
                int bottom = right;

                int topLeft = sourceAr[top][left + i];
                sourceAr[top][left + i] = sourceAr[bottom - i][left];
                sourceAr[bottom - i][left] = sourceAr[bottom][right - i];
                sourceAr[bottom][right - i] = sourceAr[top + i][right];
                sourceAr[top + i][right] = topLeft;
            }

            left++;
            right--;
        }

        return sourceAr;
    }
}