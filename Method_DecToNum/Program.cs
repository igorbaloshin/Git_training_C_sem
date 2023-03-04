Console.Clear();

Console.WriteLine("Введите число :");

int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите систему исчисления :");

int system = int.Parse(Console.ReadLine());

string res = DecToNum(number, system);

Console.WriteLine($"{number} -> {res}");


//Универсальный математический для перевода из 10 в любую
string DecToNum(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        int ost = decNumber / otherSystem;
        res = nums[decNumber - otherSystem * ost] + res;
        decNumber /= otherSystem;
    }
    return res;
}
