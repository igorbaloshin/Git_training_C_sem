// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();
Write("Введите m: ");
int m = int.Parse(ReadLine());
Write("Введите n: ");
int n = int.Parse(ReadLine());



int NumbersRec(int m, int n)
{
    if(n == m) 
    return m;
    else
    return n +  NumbersRec(m, n - 1);
    
}

WriteLine(NumbersRec(m, n));