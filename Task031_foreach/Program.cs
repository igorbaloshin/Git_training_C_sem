// Задайте массив из 12 элементов заполненый случайными числами из промежутка [-9,9]
// найдите сумму отрицательных и положительных элементов массива.

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

//----------------------------------------
// Мой вариант функции

// void  FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(-9, 10);
//         index++;
//     }
// }

int[] SumNP (int[] Collection)
{
    int[] SumNP = new int[2];
    foreach(int el in Collection)
    {
        SumNP[0] += el < 0 ? el : 0;
        SumNP[1] += el > 0 ? el : 0;
    }
    return SumNP;
}

//----------------------------------------
// Мой вариант функции:

// int[] SumNP (int[] collection)
// {
//     int[] SumNP = new int[2];
//     int  count = collection.Length;
//     int index = 0;
//     int sumNeg = 0;
//     int sumPos = 0;
//     while(index < count)
//     {
//         if(collection[index] < 0)
//         {
//             sumNeg += collection[index];
//             index++;
//         }
//         else if(collection[index] > 0)
//         {
//             sumPos += collection[index];
//             index++;
//         }
//     }
//     SumNP[0] = sumNeg;
//     SumNP[1] = sumPos;
//     return SumNP;
// }



//-----------------------------------------------

int[] Collection = GetRandomArray(12, -9, 9);
//Мой вариант
//int[] Collection = new int[12];

//FillArray(Collection);

Console.WriteLine(String.Join(", ", Collection));


Console.WriteLine($"{SumNP(Collection)[0]}, {SumNP(Collection)[1]}");