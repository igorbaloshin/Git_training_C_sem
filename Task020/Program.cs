// Принимаем число N выдаем сумму от 1 до N

Console.Clear();

// int GetSum(int n)
// {
// int sum = 0;
// for(int i = 1; i <= n; i++)
//     sum += i;
// return sum;
// }

// Console.WriteLine("Введите число :");
// int n = int.Parse(Console.ReadLine());
// //int result = GetSum(n);
// Console.WriteLine($"Сумма от 1 до {n} равна {GetSum(n)}");
//--------------------------------------------------
// Произведение


int GetMultiply(int n)
{
    int mult = 1;
    int i = 1;
    if(n < 0)
    {
       i = n;
       n = -1;
    }
    for(; i <= n; i++)
    {
       mult *= i;
    }
    return mult;
}

Console.WriteLine("Введите число :");
int n = int.Parse(Console.ReadLine());
int k = 1;
if(n < 0)
k = -1;
//int result = GetMultiply(n);
Console.WriteLine($"Произведение от {k} до {n} равна {GetMultiply(n)}");