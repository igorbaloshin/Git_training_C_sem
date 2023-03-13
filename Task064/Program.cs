// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using System;
using static System.Console;

Clear();

Write("Введите M: ");
int m = int.Parse(ReadLine());

Write("Введите N: ");
int n = int.Parse(ReadLine());




string NumbersRec( int m,int n)
{
    if(n >= m) 
    return
    $"{n} " + NumbersRec(m, n - 1);
    else return String.Empty;
}

WriteLine(NumbersRec(m, n));