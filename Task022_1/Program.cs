// Доп на вход массив удлать все повторения.
// 1.Массив для уникальных значений
// 2.Функция ищет значение в массиве
// qwe; 123; asd; dgfdg; 123123; dfgdfg; 34345; gdfgdf; sdfsdf

Console.Clear();

bool FindElInMas(string[] array, string el)
{
    for (int i = 0; i < array.Length; i++)
        if (el == array[i])
            return false;
    return true;
}

List<string> split(string s, string s2)
{
    List<string> result = new List<string>();
    s += s2;
    string s1 = ""; // String.Empty;

    for (int i = 0; i < s.Length - 1;i++){
        if (s2 == s[i].ToString() + s[i + 1].ToString())
        {
            result.Add(s1);
            s1 = "";
            i++;
        }else{
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

Print(split("123; 124; aasdas; asda sd", "  "));
double a = Convert.ToDouble(123);
