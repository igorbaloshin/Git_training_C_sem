// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Write($" {inArray[i,j]} ");
        }
        WriteLine();
    }
}

int [,] collection = GetDoubleArray(4, 4, 0, 5);
PrintArray(collection);

double[] SredArifmColums(int[,] inArray)
{
    int sum = 0;
    double sredneearifm = 0;
    double[] sredneeArifm = new double[inArray.GetLength(1)];
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum = sum + inArray[i,j];
            
        }
        sredneearifm = Convert.ToDouble(sum)/inArray.GetLength(0);
        sredneeArifm[j] = sredneearifm;
        sum = 0;
        sredneearifm = 0;
        
    }
    return sredneeArifm;

}

WriteLine();

WriteLine($"Среднее арифметическое по столбцам  {String.Join("  ", SredArifmColums(collection))}");