using System;
using static System.Console;

Clear();


int[,] GetDoubleArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write("{0,2:F0} ", inArray[i, j]);
        }
        WriteLine();
    }
}

int[,] collection = GetDoubleArray(5, 5, 0, 10);
PrintArray(collection);

int[,] InverseDoubleArray(int[,] inArray)
{
    int[,] outArray = new int[inArray.GetLength(1), inArray.GetLength(0)];
    int row = inArray.GetLength(0);
    int col = inArray.GetLength(1);
    if (row != col)
    {
         WriteLine("Невозможно инвертировать массив");
    }
    else

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            outArray[j, i] = inArray[i, j];
        }

    }
    return outArray;

}
WriteLine();

PrintArray(InverseDoubleArray(collection));
