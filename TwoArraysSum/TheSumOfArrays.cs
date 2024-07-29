using System;

namespace TwoArraysSum
{
    public class TheSumOfArrays
    {
        public static int[,] ArraySum()
        {
            int[,] arr1 = { { 1, 1, 1 }, { 1, 1, 1 } };
            int[,] arr2 = { { 1, 1, 1 }, { 1, 1, 1 } };
            int[2,3] sum;

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    sum[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            return sum;
        }
    }
}
