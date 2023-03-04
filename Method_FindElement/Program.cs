Console.Clear();

Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (FindElement(baseArray, n))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

Console.WriteLine($"Индекс элемента {IndexOf(baseArray, n)}");


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

bool FindElement(int[] array, int el)//[1,2,3,4] 5
{
    foreach (var item in array)//
    {
        if (el == item) // 5 == 4
            return true; 
    }
    return false;
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;

}
