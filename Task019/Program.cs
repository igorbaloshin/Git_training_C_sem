// Написать квадраты всех чисел от 0 до N

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
//-------------------------------------------
// int[] mas = new int[N];
// for(int i = 1; i <= N; i++)

//     mas[i - 1] = i * i;
   
// for(int i = 0; i < N; i++)

//-----------------------------------------

// int i = 1;
// int M = N;
// if(N < 0)
// {
//      i = N;
//      M = -N;
//      N = -1;
// }
// int[] mas = new int[M];
// int j = 0;
// for(; i <= N; i++ )
// {
//     mas[j] = i * i;
//     j++;
// }

// for(j = 0; j < M; j++)
// {
//      Console.Write($"{mas[j]}  ");
// }
//-----------------------------------------------
int Kvadrat(int a)
{
    int S = a * a ;
    return S;
}

void Print(int b)
{
    Console.Write($"{b}, ");
}
if (N >= 0)
{
for(int i = 0; i <= N; i++)
{
    int S = Kvadrat(i);
    Print(S);
}
}
if (N < 0)

for(int i = N; i <= -1; i++)
{
   int S = Kvadrat(i);
    Print(S);
}
