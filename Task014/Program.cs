﻿// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да



Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());//((a||c)&&(d||v))
if (num % 7 == 0 && num % 23 == 0)
// 161 % 7 == 0  * 161 % 23 == 0
//    1          *      1   = 1 
{
    Console.WriteLine("Да");
}else{
    Console.WriteLine("Нет");
}
