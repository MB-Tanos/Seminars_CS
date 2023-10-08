
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество цифр: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        int temp = Convert.ToInt32(Console.ReadLine());
        array[i] = temp;
    }
    return array;
}

int FindNumGreaterNull(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

string GetArrayStr(int[] array)
{
    string arrayStr = string.Empty;
    arrayStr += "[";
    for (int i = 0; i < array.Length; i++)
    {
        arrayStr += $"{array[i]}";
        arrayStr += i < array.Length - 1 ? ", " : "";
    }
    arrayStr += "]";
    return arrayStr;
}

int[] array = GetArray(n);

Console.WriteLine($"В массиве: {GetArrayStr(array)}, {FindNumGreaterNull(array)} - положительных чисел");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

string FindNumbers(double b1, double k1, double b2, double k2)
{
    string result = string.Empty;

    double x = 0;
    double y = 0;

    x = (b1 - b2) / (k2 - k1);
    y = k1 * x + b1;
    result = $"({x}; {y})";
    return result; 
}

Console.WriteLine(FindNumbers(b1, k1, b2, k2));