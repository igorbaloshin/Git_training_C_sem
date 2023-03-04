// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

int FindMaxArray(int[] col)
{
    int max = col[0];
    for(int i = 0; i < col.Length - 1; i++)
    {
        if(col[i] > max)
        {
            max = col[i];
        }
    }   
    return max;
}

int FindMinArray(int[] col)
{
    int min = col[0];
    for(int i = 0; i < col.Length; i++)
    {
        if(col[i] < min)
        {
            min = col[i];
        }
    }
    return min;
}



int[] array = GetRandomArray(n, 1, 10);

PrintArray(array);

Console.WriteLine();

Console.WriteLine($"Максимальное число  {FindMaxArray(array)}");
Console.WriteLine($"Минимальное  число  {FindMinArray(array)}");
Console.WriteLine($"Разница             {FindMaxArray(array) - FindMinArray(array)}");








