// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

void PrintArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //Console.Write($"{array[i, j]} ");
            Console.Write(string.Format("{0:0.00} ", array[i, j]));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-9, 10) + Math.Round(new Random().NextDouble(), 2);
    }
}

PrintArrayDouble(arr);

// Задача 48: Задайте двумерный массив размера m на n, каждый 
// элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] arrayNew = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arrayNew[i, j] = i + j;
    }
}

PrintArray(arrayNew);

int[,] arrayNew2 = new int[m, n];

for (int i = 0; i < arrayNew2.GetLength(0); i++)
{
    for (int j = 0; j < arrayNew2.GetLength(1); j++)
    {
        arrayNew2[i, j] = n*i + j;
    }
}

PrintArray(arrayNew2);

// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса не чётные, и замените эти элементы на их 
// квадраты.

int[,] array49 = new int[m, n];

for (int i = 0; i < array49.GetLength(0); i++)
{
    for (int j = 0; j < array49.GetLength(1); j++)
    {
        array49[i, j] = new Random().Next(-9, 10);        
    }
}

PrintArray(array49);

for (int i = 0; i < array49.GetLength(0); i++)
{
    for (int j = 0; j < array49.GetLength(1); j++)
    {
        if(i % 2 == 1 && j % 2 == 1)
        {
            array49[i, j] = Convert.ToInt32(Math.Pow(array49[i, j], 2));
        }
    }
}

PrintArray(array49);

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int[,] array51 = new int[m, n];

for (int i = 0; i < array51.GetLength(0); i++)
{
    for (int j = 0; j < array51.GetLength(1); j++)
    {
        array51[i, j] = new Random().Next(1, 10);        
    }
}

PrintArray(array51);

int sum = 0;
for (int i = 0; i < array51.GetLength(0); i++)
{
    for (int j = 0; j < array51.GetLength(1); j++)
    {
        if(i == j)
        {
            sum += array51[i, j];
        }      
    }
}

Console.WriteLine(sum);