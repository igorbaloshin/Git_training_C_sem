// Входные данные
// В первой строке входного файла INPUT.TXT записано целое число N (0 < N ≤ 100). Во второй строке через пробел заданы N натуральных чисел, не превосходящих 100, соответствующие стоимости C[i] 1 сантиметра волос за каждый i-й день.

// Выходные данные
// В единственную строку выходного файла OUTPUT.TXT нужно вывести максимальную денежную сумму, которую может заработать неформал за N дней.

Console.Clear();
Console.WriteLine("Введите стоимость волос по каждому дню через пробел :");

string elements = Console.ReadLine();

int[] baseArray = GetArrayFromString(elements);

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

//Console.WriteLine(String.Join(", ", baseArray));


int[] MaxElementsArray(int[] collection)
{
    int[] sequence = new int[collection.Length];
    int maxPosition = 0;

    for (int i = 0; i < collection.Length; i = maxPosition)
    {

        for (int j = i + 1; j < collection.Length; j++)
        {
            if (collection[j] >= collection[maxPosition])
                maxPosition = j;
        }
        sequence[maxPosition] = collection[maxPosition];
        maxPosition += 1;
    }
    return sequence;
}

int[] newArray = MaxElementsArray(baseArray);

//Console.WriteLine(String.Join(", ", newArray));

int Revenue(int[] array)
{
    int day = 1;
    int revenue = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0)
        {
            revenue = revenue + array[i] * day;
            day = 1;
        }
        else
            day += 1;
    }
    return revenue;
}

Console.WriteLine($"Полученный доход от продажи волос : {Revenue(newArray)}");




