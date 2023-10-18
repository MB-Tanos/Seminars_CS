// задача 63. Задайте значение N. Напишите программу, которая вывыедет
// все натуральные числа в промежутке от 1 до N

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void Print(int n)
{
    Console.Write($"{n} -> ");
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}
Print(N);

// Рекурсия

string PrintNumber(int start, int end)
{
    if(start == end)
    {
        return Convert.ToString(start);
    }
    return $"{start} {PrintNumber(start + 1, end)}";
}

Console.Write($"{N} -> {PrintNumber(1, N)}");

// Задача 65
// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа от M до N

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
N = Convert.ToInt32(Console.ReadLine());

void PrintNew(int m, int n)
{
    if(m == n)
    {
        Console.Write(m);
        return;
    }
    Console.Write($"{m} ");
    PrintNew(m + 1, n);
}

PrintNew(M, N);

// Задача 67
// Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр

Console.Write("Введите число N: ");
N = Convert.ToInt32(Console.ReadLine());

int SumNumber(int N)
{
    if (N == 0)
    {
        return N;
    }
    return N % 10 + SumNumber(N / 10);
}

Console.WriteLine($"Сумма цифр числа {N} равна {SumNumber(N)}");


// Задача 69
// Напишите программу, которая на вход принимает числа A и B и возводит
// A в целую степень B с помощью рекурсии
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int Pow(int A, int B)
{
    if (B == 0) return 1;
    else if (B == 1) return A;
    else
    {
        return A * Pow(A, B-1);
    }
}

Console.Write($"Если возвести число {A} в степень {B}, то получится: {Pow(A, B)}");
