// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int myPow(int a, int b)
{
    int pow = 1;
    for (int i = 0; i < b; i++)
    {
        pow *= a;    
    }
    return pow;
}

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Если возвести число {a} в степень {b} равна {myPow(a, b)}\n");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void CountNumber(int num)
{
    int count = 0;
    int oldNum = num;
    while (num > 0)
    {
        count += num % 10;
        num /= 10;
    }

    Console.WriteLine($"Сумма цифр числа {oldNum} равна {count}\n");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

CountNumber(num);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.(вводить диапазон рандома пользователем)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void MassRandom(int length, int numStart, int numEnd)
{
    int[] array = new int[length];
    if(numStart > numEnd)
    {
        int temp = numStart;
        numStart = numEnd;
        numEnd = temp;
    }
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(numStart, numEnd + 1);
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"\b\b]");
}

Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапазона элементов: ");
int numStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона элементов: ");
int numEnd = Convert.ToInt32(Console.ReadLine());
MassRandom(arrayLength, numStart, numEnd);
Console.WriteLine();



