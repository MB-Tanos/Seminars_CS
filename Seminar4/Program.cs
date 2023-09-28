// Задача 24: Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

int Sum(int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine($"Сумма чисел от 1 до {a} равна {Sum(a)}\n");

//----------------------------------------------------------

void Mass(int col)
{
    // пустой массив с заданным количеством элементов("col")
    int[] array = new int[col];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Mass(n);
Console.WriteLine();

// Задача 26: Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

void CountNum(int num)
{
    int count = 0;
    int oldNum = num;
    while (num > 0)
    {
        num /= 10;
        count++;
    }

    Console.WriteLine($"В числе {oldNum} - {count} цифр\n");
}

CountNum(n1);

// Console.Write("Введите число 2: ");
// string num = Console.ReadLine();


// void CountNumStr(string num)
// {
//     Console.WriteLine($"В числе {num} - {num.Length} цифр\n");
// }

// CountNumStr(num);

// Задача 28: Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void MultNum(int num)
{
    int mult = 1;
    
    for (int i = 1; i <= num; i++)
    {
        mult *= i;
    }
    Console.WriteLine($"Произведение чисел от 1 до {num} - {mult}\n");
}

MultNum(num);

// Задача 30: Напишите программу, которая выводит массив из 8 
// элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void MassRandom(int col)
{
    int[] array = new int[col];
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"\b\b]");
}

Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
MassRandom(arrayLength);
Console.WriteLine();