// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


using System;
using static System.Console;

Clear();
Write("Введите число m : ");
int m = int.Parse(ReadLine());
Write("Введите число n: ");
int n = int.Parse(ReadLine());

int AkkermanRec(int m, int n)
{
    if(m == 0)
    return n + 1;
    if(m != 0 && n == 0)
    return AkkermanRec(m - 1, 1);
    else
    return AkkermanRec(m - 1, AkkermanRec(m, n - 1));

}


WriteLine(AkkermanRec(m, n));
