//  Вывод массива Фибоначи

Console.Clear();

int[] Fib(int n){
    int[] mas_f = new int[n];
    mas_f[0] = 0;
    if(n >= 2){
        mas_f[1] = 1;
    }else { return mas_f; }
    for (int i = 2; i < n; i++){
        mas_f[i] = mas_f[i - 1] + mas_f[i - 2];
    }
    return mas_f;
}
Console.Clear();
Console.WriteLine("введите N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"[{String.Join(' ', Fib(n))}]");
