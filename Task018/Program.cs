// Найти расстояние между точками A и B с координатами x;Y

Console.Clear();

Console.Write("Введите X1:");
int X1 = int.Parse(Console.ReadLine());

Console.Write("Введите Y1:");
int Y1 = int.Parse(Console.ReadLine());

Console.Write("Введите X2:");
int X2 = int.Parse(Console.ReadLine());

Console.Write("Введите Y2:");
int Y2 = int.Parse(Console.ReadLine());

int S = Convert.ToInt32(Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2)));

Console.WriteLine(S);
