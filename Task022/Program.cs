// Доп на вход массив удалать все повторения.
// 1.Массив для уникальных значений
// 2.Функция ищет значение в массиве
// qwe; 123; asd; dgfdg; 123123; dfgdfg; 34345; gdfgdf; sdfsdf

Console.Clear();

bool FindElInMas(List<string> array, string el, int k = 0)
{
    for (int i = k; i < array.Count; i++)
        if (el == array[i])
            return true;
    return false;
}

List<string> DeleteValues(List<string> array, int j)
{
    List<string> result = new List<string>();
    for (int i = 0; i < array.Count; i++)
        if (i != j)
            result.Add(array[i]);
    return result;
}

List<string> DeleteEqualValues(List<string> array)
{

    for (int i = 0; i < array.Count; i++)
    {
        if (FindElInMas(array, array[i], i + 1))
        {
            array = DeleteValues(array, i);
            i--;
        }
    }
    return array;
}

List<string> split(string s)
{
    List<string> result = new List<string>();
    s += "; ";
    string s1 = ""; //String.Empty;
    for (int i = 0; i < s.Length - 1; i++)
    {
        if ("; " == s[i].ToString() + s[i + 1].ToString())
        {
            result.Add(s1);
            s1 = "";
            i++;
        }
        else
        {
            s1 += s[i];
        }
    }
    return result;
}

void Print(List<string> s)
{
    for (int i = 0; i < s.Count - 1; i++)
    {
        Console.Write($"{s[i]}, ");
    }
    Console.WriteLine(s[s.Count - 1]);
}
List<string> arr = split("123; 124; aasdas; asda sd; 123; 123; 124; 124");
Print(arr);
Print(DeleteEqualValues(arr));
