using System;
class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int[,] copiedArray = (int[,])myMatrix.Clone();

        for (int i = 0; i < copiedArray.GetLength(0); i++)
        {
            for (int j = 0; j < copiedArray.GetLength(1); j++)
            {
                copiedArray[i, j] *= copiedArray[i, j];
            }
        }
        return copiedArray;
    }
}
