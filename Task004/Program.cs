﻿//Напишите программу, которая на вход принимает одно число (N), 
// 4
//-4
//а на выходе показывает все целые числа в промежутке от -N до N.

Console.Clear();
Console.Write("Введите число: ");


int N= int.Parse(Console.ReadLine());
int B=-N;
while (B<=N)
{
    Console.Write($"{B} ");
    B++;

}
