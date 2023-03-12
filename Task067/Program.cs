/***Задача 67:**Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.

453 -> 12

45 -> 9*/

using System;
using static System.Console;
Clear();
WriteLine("Введите число : ");
int m = int.Parse(ReadLine());

WriteLine($"{m} -> {SumNumbers(m)}");

int sum = 0;
while( m > 0)
{
    sum += m % 10;
    m /= 10;
}
WriteLine($"{sum}");


int SumNumbers(int m)
{
    if(m == 0)
        return 0;
    return(m % 10 + SumNumbers( m / 10));
}