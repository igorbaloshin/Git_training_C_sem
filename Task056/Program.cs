// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


int SelectionMinString(int[,] inArray)
{
    int[] Sum = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum = sum + inArray[i, j];
        }
        Sum[i] = sum;
        sum = 0;
    }

    int indexmin = 0;
    int min = Sum[0];
    for (int i = 0; i < Sum.Length; i++)
    {
        if (Sum[i] < min)
        {
            indexmin = i;
        }
    }
    return indexmin;

}


int[,] collection = GetDoubleArray(4, 4, 0, 9);
PrintArray(collection);

WriteLine($"Минимальная сумма злементов в строке :{SelectionMinString(collection) + 1}");