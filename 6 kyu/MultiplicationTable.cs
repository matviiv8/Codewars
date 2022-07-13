/*
Your task, is to create NxN multiplication table, of size provided in parameter.

for example, when given size is 3:

1 2 3
2 4 6
3 6 9
for given example, the return value should be: [[1,2,3],[2,4,6],[3,6,9]]
*/

using System;

namespace Solution
{
    class Solution
    {
        public static int[,] MultiplicationTable(int size)
        {
            int[,] matrix = new int[size, size];
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    matrix[i - 1, j - 1] = i * j;

                }
            }
            return matrix;
        }
    }
}
