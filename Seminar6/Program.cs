/*
// Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int minArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxArr = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.Write("\b\b\b\b]\n\n");
}

int[] GenArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);       
    }
    return array;
}

int[] ReverseArray(int[] array)
{
    int temp = 0;
    int lastNum = array.Length - 1;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[lastNum - i];
        array[lastNum - i] = temp;
    }
    return array;
}

int[] array = GenArray(n, minArr, maxArr);
PrintArray(array);
array = ReverseArray(array);
PrintArray(array);


// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool CheckTriangle(int a, int b, int c)
{
    if((a < b + c) && (b < a + c) && (c < a + b))
    {
        return true;
    }
    return false;
}

Console.Write("Введите A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите C: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Имеется ли треугольник: {CheckTriangle(a, b, c)}");


// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10 

string ChangeTenToTwo(int numTen)
{
    string newNum = string.Empty;
    while (numTen > 1)
    {
        newNum = $"{numTen % 2}" + newNum;
        numTen /= 2;
        newNum = (numTen == 1 ? "1" : "") + newNum;
    }

    return newNum;
}

Console.Write("Введите число в десятичной системе счисления: ");
int numTen = Convert.ToInt32(Console.ReadLine());
string numTwo = ChangeTenToTwo(numTen);
Console.WriteLine($"Если перевести число {numTen} в двоичную СС, то получится: {numTwo}");
*/
// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа: 0, 1
// Если N = 5: 0 1 1 2 3

void PrintArrayNew(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.Write("\b\b\b\b]\n\n");
}

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
array[0] = 0;
array[1] = 1;
for (int i = 2; i < num; i++)
{
    array[i] = array[i - 1] + array[i - 2];
}

PrintArrayNew(array);

// Задача 45: Напишит программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования
int[] CopyArrayTo(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

int[] arr = new int[] {1, 2, 3, 4, 5, 6};
int[] newArr = CopyArrayTo(arr);
PrintArrayNew(newArr);