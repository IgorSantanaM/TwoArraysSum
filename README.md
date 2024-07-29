# Two Arrays Sum

## Problem Description
The task is to sum the elements of two 2D arrays of the same dimensions, element-wise. Given two 2D arrays, the result should be a new 2D array where each element is the sum of the corresponding elements from the two input arrays.

## Solution
The solution involves iterating over each element of the arrays, summing the corresponding elements, and storing the result in a new 2D array. 

### Code Explanation
The project includes two main parts:
1. **TheSumOfArrays Class**: Contains the logic to sum two 2D arrays.
2. **Program Class**: The entry point of the application that demonstrates the usage of the `ArraySum` method and prints the result.

### TheSumOfArrays Class
This class includes a static method `ArraySum` which takes two 2D arrays as parameters and returns their element-wise sum.

```csharp
using System;

namespace TwoArraysSum
{
    public class TheSumOfArrays
    {
        // Method to sum two 2D arrays
        public static int[,] ArraySum(int[,] arr1, int[,] arr2)
        {
            int rows = arr1.GetLength(0);
            int cols = arr1.GetLength(1);
            int[,] sum = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            return sum;
        }
    }
}
```
Program Class
This class contains the Main method which initializes two 2D arrays, calls the ArraySum method, and prints the resulting summed array.

``` csharp
using System;
using TwoArraysSum;

class Program
{
    public static void Main(string[] args)
    {
        int[,] arr1 = { { 1, 1, 1 }, { 1, 1, 1 } };
        int[,] arr2 = { { 1, 1, 1 }, { 1, 1, 1 } };

        int[,] result = TheSumOfArrays.ArraySum(arr1, arr2);

        Console.WriteLine("The sum of the two arrays is:");
        PrintArray(result);
    }

    // Helper method to print a 2D array
    private static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
```
### Usage
To use this code, simply compile and run the Program class. It will print the element-wise sum of the two 2D arrays defined in the Main method.

Example Output
``` python
The sum of the two arrays is:
2 2 2 
2 2 2
```
This output shows the element-wise sum of the arrays arr1 and arr2, where each element in the resulting array is the sum of the corresponding elements from the input arrays.

### Conclusion
This project provides a simple example of summing two 2D arrays in C#. It demonstrates basic array manipulation and iteration techniques, and serves as a useful reference for similar array processing tasks.
