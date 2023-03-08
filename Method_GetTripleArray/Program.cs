using System;
using static System.Console;

Clear();


int[,,] GetTripleArray(int l, int m, int n, int minValue, int maxValue)
{
    int[,,] result = new int[l, m, n];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for(int k = 0; k < n; k++)
            {
                 result[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
           
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for(int k = 0; k < inArray.GetLength(2); k++)
            {
            //Write($" {inArray[i,j,k]} ( {i}, {j}, {k})");
            Write("{0,2:F0} ",inArray[i,j,k]);
            Write($"({i}, {j}, {k})");
            }
            WriteLine();
        }
        WriteLine();
    }
    WriteLine();
}

int [,,] collection = GetTripleArray(3, 3, 2, 0, 6);
PrintArray(collection);

