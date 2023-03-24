// Доп на вход массив удлать все 'элементы длиннее 3'.
// 1.Массив для уникальных значений
// 2.Функция ищет значение в массиве
// qwe; 123; asd; dgfdg; 123123; dfgdfg; 34345; gdfgdf; sdfsdf

Console.Clear();

void SortArray(List<string> inArray)
{
    for (int i = 0; i < inArray.Count; i++)
    {
        for (int j = i + 1; j < inArray.Count; j++)
        {
            if(inArray[j].Length < inArray[i].Length)                                        
            {
                string k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }

        }
    }
}

void Print(List<string> s)
{
    for (int i = 0; i < s.Count - 1; i++)
    {
        Console.Write($"{s[i]}, ");
    }
    Console.WriteLine(s[s.Count - 1]);
}

List<string> Change(List<string> inArray)
{
    string el = inArray[0];
    List<string> result = new List<string>();
    for (int i = 1; i < inArray.Count(); i++)
    {
        if (el.Length <= 3)
        {
            result.Add(el);
            el = inArray[i];
        }
    }
    return result;
}

List<string> arr = new List<string> { "123","1237654", "123", "1234", "23452345", "23452345", "1234", "dsfadfasdf", ":<&", "%^", "qwe", "123", "asd", "dgfdg", "123123", "dfgdfg", "34345", "gdfgdf", "sdfsdf" };
SortArray(arr);
Print(arr);
Print(Change(arr));