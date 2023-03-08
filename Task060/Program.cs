// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

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
            //Write($" {inArray[i,j,k]:F0} ( {i}, {j}, {k})");
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
