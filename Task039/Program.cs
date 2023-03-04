// **Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

Console.Clear();

int[] GetRandomArray(int length, int minValue, int maxValue)
{
    int[] Collection = new int[length];
    for(int index = 0; index < length; index++)
    {
        Collection[index] = new Random().Next(minValue, maxValue +1);
    }
    return Collection;

}

int[] InverseArray(int[] array)
{
    int[] arrayresult = new int[array.Length];
    
    for(int i = 0; i <= (array.Length)/2; i++)
    {
        int temp = array[i];
        arrayresult[i] = array[array.Length - 1 - i ];
        arrayresult[array.Length -1 -i] = temp;
    }
    return arrayresult;

}
int[] Collection = GetRandomArray(5, -7, 7);
Console.WriteLine(String.Join(", ", Collection));
int[] InverseCollection = InverseArray(Collection);
Console.WriteLine(String.Join(", ", InverseCollection));