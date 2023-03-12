// **Задача 69:**Напишите программу,
//  которая на вход принимает два числа A и B,
//   и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5-> 243(3⁵)

// A = 2; B = 3-> 8
 using System;
 using static System.Console;

 Clear();

 WriteLine("Введите число :");

 int a = int.Parse(ReadLine());

 WriteLine("Введите степень :");

 int n = int.Parse(ReadLine());



 int PowerFor(int a,int n)
{
    int result = 1;
    for(int i = 1; i <= n; i++)
    {
        result *= a;
    }

    return result;
}

int PowerRec(int a,int n)
{
    if(n == 0) return 1;
    else return a * PowerRec(a, n - 1);
}

WriteLine(PowerFor(a, n));
WriteLine(PowerRec(a, n));