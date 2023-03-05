// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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

bool CheckDoubleArray(int[,] inArray, int n)
{
    bool res = false;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if(inArray[i,j] == n)
            res  = true;
        }
        
    }
    return res;
}

int [,] collection = GetDoubleArray(4, 4, 0, 10);
PrintArray(collection);

Write("Введите число: ");
int N = int.Parse(ReadLine());
if(CheckDoubleArray(collection, N) == true)
WriteLine("Такое число имеется");
else
WriteLine("Такое числа нет");




