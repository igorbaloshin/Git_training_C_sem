using System;
using static System.Console;

Clear();


double[,] GetDoubleArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*(maxValue - minValue) + minValue;
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            //Write($"{inArray[i,j]:F2} ");
            Write("{0,9:F1}  ", inArray[i,j]);
        }
        WriteLine();
    }
}

double [,] collection = GetDoubleArray(3, 4, 1, 10);
PrintArray(collection);