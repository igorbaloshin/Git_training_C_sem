Console.Clear();
Console.Write("Введите трехзначное число: ");
int num=int.Parse(Console.ReadLine());
int y=num%100;

Console.WriteLine($"{y}");