/*
// Задача 31: Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и 
// положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна -20

int[] GetArrayOld(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    
    if (minValue > maxValue)
    {
        int temp = minValue;
        minValue = maxValue;
        maxValue = temp;
    }

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{result[i]} ");
    }
    Console.WriteLine();
    return result;
}

Console.Write("Введите число элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный элемент массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = GetArrayOld(size, minValue, maxValue);

int sumPos = 0;
int sumNeg = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] < 0)
    {
        sumNeg += array[i];   
    }
    else
    {
        sumPos += array[i]; 
    }
}

Console.WriteLine($"Сумма положительных чисел массива равна {sumPos}, сумма отрицательных равна {sumNeg}");


// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    if (minValue > maxValue)
    {
        int temp = minValue;
        minValue = maxValue;
        maxValue = temp;
    }

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{result[i]} ");
    }
    Console.WriteLine();
    return result;
}

Console.Write("Введите число элементов массива: ");
size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный элемент массива: ");
minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент массива: ");
maxValue = Convert.ToInt32(Console.ReadLine());

array = GetArray(size, minValue, maxValue);

for (int i = 0; i < array.Length; i++)
{
    array[i] *= (-1);
    Console.Write($"{array[i]} ");
}
Console.WriteLine("\n");

// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

int[] arrayNew = GetArray(size, minValue, maxValue);
Console.Write("Введите число для проверки в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());

bool NumberIn(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (Math.Abs(array[i]) == Math.Abs(num))
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine($"Число {num} присутствует в новом массиве? {NumberIn(arrayNew, num)}");


// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetArrayNew(int minValue, int maxValue, int size = 123)
{
    int[] result = new int[size];

    if (minValue > maxValue)
    {
        int temp = minValue;
        minValue = maxValue;
        maxValue = temp;
    }

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{result[i]} ");
    }
    Console.WriteLine();
    return result;
}

int NumbersBetween(int[] array, int start = 10, int end = 99)
{
    int n = 0;
   for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            n++;
        }
    }
    return n;
}

Console.Write("Введите минимальный элемент массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"В новом массиве {NumbersBetween(GetArrayNew(minValue, maxValue))} элементов находятся в выбранном промежутке.");
*/

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArrayNew(int minValue, int maxValue, int size = 4)
{
    int[] result = new int[size];

    if (minValue > maxValue)
    {
        int temp = minValue;
        minValue = maxValue;
        maxValue = temp;
    }

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{result[i]} ");
    }
    Console.WriteLine();
    return result;
}

void NewArray(int[] array)
{
    int sizeNew = array.Length / 2 + array.Length % 2;    
    int[] newArray = new int[sizeNew];

    if(sizeNew % 2 == 1)
    {
        newArray[sizeNew - 1] = array[sizeNew - 1];
    }

    for (int i = 0; i < newArray.Length - sizeNew % 2; i++)
    {
        int temp = array[i] * array[array.Length - 1 - i];
        newArray[i] = temp;
    }

    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"{newArray[i]} ");
    }
    Console.WriteLine();

}

Console.Write("Введите минимальный элемент массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = GetArrayNew(minValue, maxValue);
NewArray(array);