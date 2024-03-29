﻿using System;
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


void SelectionStringToMin(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            //int minPosition = j;
            int maxPosition = j;
            for (int k = j + 1; k < inArray.GetLength(1); k++)
            {
                //if(inArray[i,k] < inArray[i,minPosition])
                if (inArray[i, k] > inArray[i, maxPosition])
                    //minPosition = k;
                    maxPosition = k;

            }

            int temporary = inArray[i, j];
            //inArray[i,j] = inArray[i,minPosition];
            inArray[i, j] = inArray[i, maxPosition];
            //inArray[i,minPosition] = temporary;
            inArray[i, maxPosition] = temporary;
        }
    }
}

int[,] collection = GetDoubleArray(4, 4, 0, 9);
PrintArray(collection);

SelectionStringToMin(collection);

WriteLine();

PrintArray(collection);
