//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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

int[] array = GetRandomArray(n, 100, 1000);

int count = 0;

for(int i = 0; i < n; i++)
{ 
    if(array[i]%2 == 0)
    count++;

}

PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Количество четных элементов  {count}");
