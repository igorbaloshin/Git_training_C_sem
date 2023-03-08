// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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
            //Write($" {inArray[i,j]} ");
            Write("{0,3:F0}  ", inArray[i, j]);
        }
        WriteLine();
    }
}



int[,] MatrixMult(int[,] inArray_1, int[,] inArray_2)
{

    int[,] Res = new int[inArray_1.GetLength(0), inArray_2.GetLength(1)];

    if (inArray_1.GetLength(1) != inArray_2.GetLength(0))
    {
        WriteLine("Размеры матриц не позволяют их перемножить");
    }
    else
    {
        int res = 0;

        for (int i = 0; i < inArray_1.GetLength(0); i++)
        {
            for (int ij = 0; ij < inArray_2.GetLength(1); ij++)
            {
                for (int j = 0; j < inArray_1.GetLength(1); j++)
                {
                    res = res + inArray_1[i, j] * inArray_2[j, ij];
                }
                Res[i, ij] = res;
                res = 0;

            }
        }

    }
    return Res;

}

int[,] collection_1 = GetDoubleArray(3, 4, 0, 6);

PrintArray(collection_1);

WriteLine();

int[,] collection_2 = GetDoubleArray(4, 5, 0, 6);

PrintArray(collection_2);

WriteLine();

int[,] Result = MatrixMult(collection_1, collection_2);

PrintArray(Result);

