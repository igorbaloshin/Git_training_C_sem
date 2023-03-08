

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


void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        //int minPosition = i;
        int maxPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            //if(array[j] < array[minPosition])
            if(array[j] > array[maxPosition])
            //minPosition = j;
            maxPosition = j;

        }

        int temporary = array[i];
        //array[i] = array[minPosition];
        array[i] = array[maxPosition];
        //array[minPosition] = temporary;
        array[maxPosition] = temporary;
    }
}

int[] arr = GetRandomArray(10, 1, 10);

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
