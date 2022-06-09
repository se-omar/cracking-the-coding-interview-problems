using CTCIProblems.ArraysAndStrings;


int[][] matrix = new int[3][];

    matrix[0] = new[] {1, 2, 3};
    matrix[1] = new[] {4, 5, 6};
    matrix[2] = new[] {7, 8, 9};


RotateMatrix rotateMatrix = new();
Console.WriteLine(rotateMatrix.Solution(matrix));