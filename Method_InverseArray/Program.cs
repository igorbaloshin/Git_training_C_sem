int[] GetRandomArray(int length, int minValue, int maxValue)
{
    int[] Collection = new int[length];
    for(int index = 0; index < length; index++)
    {
        Collection[index] = new Random().Next(minValue, maxValue +1);
    }
    return Collection;

}


int[] Collection = GetRandomArray(4, -7, 7);
Console.WriteLine(String.Join(", ", Collection));
