using System.Data;

namespace CTCIProblems.ArraysAndStrings;

public class ZeroMatrix
{
    public int[][] Solution(int[][] mat, int rowCount, int colCount)
    {
        bool[] rowsToBeZero = new bool[rowCount];
        bool[] colsToBeZero = new bool[colCount];
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                if (mat[i][j] == 0)
                {
                    rowsToBeZero[i] = true;
                    colsToBeZero[j] = true;
                }
            }
        }

        ZeroRows(mat, rowsToBeZero, colCount);
        ZeroCols(mat, colsToBeZero, rowCount);

        return mat;
    }

    public void ZeroRows(int[][] mat, bool[] rowsToBeZero, int colCount)
    {
        for (int i = 0; i < rowsToBeZero.Length; i++)
        {
            if (rowsToBeZero[i])
            {
                for (int j = 0; j < colCount; j++) mat[i][j] = 0;
            }
        }
    }

    public void ZeroCols(int[][] mat, bool[] colsToBeZero, int rowCount)
    {
        for (int i = 0; i < colsToBeZero.Length; i++)
        {
            if (colsToBeZero[i])
            {
                for (int j = 0; j < rowCount; j++) mat[j][i] = 0;
            }
        }
    }
}