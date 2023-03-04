// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();

Console.WriteLine("Введите размер массива :");

int n = int.Parse(Console.ReadLine());

int[] GetRandomArray(int length, int minValue, int maxValue)
{
    int[] Collection = new int[length];
    for(int index = 0; index < length; index++)
    {
        Collection[index] = new Random().Next(minValue, maxValue +1);
    }
    return Collection;

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }


}

int[] array = GetRandomArray(n, 1, 10);

int sum = 0;

for(int i = 0; i < n; i++)
{ 
    if(array[i]%2 != 0)
    sum = sum + array[i] ;
}
//return sum;

PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Сумма четных элементов  {sum}");