using System;
using TwoArraysSum; 

class Program
{
    public static void Main(string[] args)
    {
        int[,] result = TheSumOfArrays.ArraySum(); 

        Console.WriteLine("The sum of the two arrays is:");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
