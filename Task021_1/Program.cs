// Определение количества цифр в строке

Console.Clear();

int CountNumbers(string number)
{
    int result = 0;
    
    for(int i = 1; i <= number.Length; i++)
    {
        result++;
    }
    return result;
}
Console.Write("Введите число: ");
int K = int.Parse(Console.ReadLine());
string N = Convert.ToString (K);
int m = 0;
if(K < 0)
m = 1;
Console.WriteLine($"Количество цифр в числе {N}  -> {CountNumbers(N)-m}");
