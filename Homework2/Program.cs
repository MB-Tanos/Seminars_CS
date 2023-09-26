int GetNumber(string text = "Введите число: ")
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int num = GetNumber("Введите трехзначное число: ");
int mediumNum = -1;
if (num < 99 || num > 999)
{
    Console.WriteLine("Введено некорректное число, попробуйте снова!\n");
}
else
{
    mediumNum = (num / 10) % 10;
    Console.WriteLine($"У числа {num} вторая цифра - {mediumNum}\n");
}

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

num = GetNumber();
int sokrNum = num;
if (sokrNum < 99)
{
    Console.WriteLine($"У числа {num} отсутствует третья цифра\n");
}
else
{
    while (sokrNum > 999)
    {
        sokrNum /= 10;
    }
    Console.WriteLine($"У числа {num} третья цифра - {sokrNum % 10}\n");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
num = GetNumber("Введите цифру дня недели: ");
if (num == 6 || num == 7)
{
    Console.WriteLine("Это выходной!");
}
else if (num > 0 && num < 6)
{
    Console.WriteLine("Это будний день!");
}
else
{
    Console.WriteLine("Такого дня недели не существует!");
}