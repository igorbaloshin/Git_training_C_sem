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
    // for (int i = 0; i < array.Length; i++)
    // {
    //     array[i] *= -1;
    // }
    // return array;
    int[] arrayresult = new int[array.Length];
    int j = 0;
    foreach(int i in array)
    {
       arrayresult[j] = i * -1;
       j++;

    }
    return arrayresult;
    
}



int[] Collection = GetRandomArray(4, -7, 7);
Console.WriteLine(String.Join(", ", Collection));
int[] InverseCollection = InverseArray(Collection);
Console.WriteLine(String.Join(", ", InverseCollection));
