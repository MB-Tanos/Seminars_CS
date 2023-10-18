// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
int[, ] ChangeArray(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
    return array;
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
}

Console.WriteLine("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-9, 10);
    }
}

PrintArray(arr);
Console.WriteLine();
arr = ChangeArray(arr);
Console.WriteLine();
PrintArray(arr);
*/

// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.
/*
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
}

int[, ] ChangeArray(int[,] array)
{
    if(array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Ваша матрица некорретная, изменение невозможно!");
        return array;
    }

    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            temp = array[j, i];
            array[j, i] = array[i, j];
            array[i, j] = temp;
        }        
        
    }
    return array;
}

Console.WriteLine("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-9, 10);
    }
}

PrintArray(arr);
Console.WriteLine();
arr = ChangeArray(arr);
Console.WriteLine();
PrintArray(arr);
*/

// Задача 57: Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит информацию 
// о том, сколько раз встречается элемент входных данных.
/*
Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(0,10);
    }
}

void PrintArr(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j]}\t");
        }
        Console.WriteLine();
    }
}

PrintArr(arr);

void Count (int[,] arry)
{   
    int count = 0;
    int number = 0;
    while(number < 10)
    {
        for (int i = 0; i < arry.GetLength(0); i++)
        {
            for (int j = 0; j < arry.GetLength(1); j++)
            {
                if(arry[i,j] == number) count++;
            }
        }   
        if(count > 0) Console.WriteLine($"Число {number} встречается {count} раз");
        count = 0;
        number++;
    }
}

Count(arr);
*/
//-------------------------
/*
Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Минимальмальная цифра в массиве ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальная цифра в массиве ");
int l = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(k,l+1);
    }
}

void PrintArr(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j]}\t");
        }
        Console.WriteLine();
    }
}

PrintArr(arr);

void Count (int[,] arry, int x, int y)
{   
    int count = 0;
    int number = x;
    while(number <= y)
    {
        for (int i = 0; i < arry.GetLength(0); i++)
        {
            for (int j = 0; j < arry.GetLength(1); j++)
            {
                if(arry[i,j] == number) count++;
            }
        }   
        if(count > 0) Console.WriteLine($"Число {number} встречается {count} раз");
        count = 0;
        number++;
    }
}

Count(arr, k, l);
*/
//------------------------------------------

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен 
// наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-9,10);
    }
}

void PrintArr(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j]}\t");
        }
        Console.WriteLine();
    }
}

PrintArr(arr);

Console.WriteLine();

int[] findMinNumberLoc(int[,] arry)
{
    int min = arry[0, 0];
    int[] result = new int[] {0,0};
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            if(arry[i,j] < min)
            {
                min = arry[i,j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

int[] delete = findMinNumberLoc(arr);

Console.WriteLine($"{delete[0]}, {delete[1]}");

void PrintFinalArr(int[,] arry, int[] delete)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
         {
            if (i != delete[0] && j != delete[1])
            {
                Console.Write($"{arry[i, j]}\t");
            }
         }
        Console.WriteLine();
    }
}

PrintFinalArr(arr, delete);

int[,] finalArray = new int[m - 1, n - 1];

for (int i = 0; i < delete[0]; i++) //заполняет верхний левый угол
{
    for (int j = 0; j < delete[1]; j++)
    {
        finalArray[i,j] = arr[i,j];
    }
}
for (int i = delete[0]; i < finalArray.GetLength(0); i++) //заполнили нижний правый
{
    for (int j = delete[1]; j < finalArray.GetLength(1); j++)
    {
        finalArray[i,j] = arr[i+1,j+1];
    }
}
for (int i = delete[0]; i < finalArray.GetLength(0); i++) //заполнили нижний левый
{
    for (int j = 0; j < delete[1]; j++)
    {
        finalArray[i,j] = arr[i+1,j];
    }
}
for (int i = 0; i < delete[0]; i++) //заполнили верхний правый
{
    for (int j = delete[1]; j < finalArray.GetLength(1); j++)
    {
        finalArray[i,j] = arr[i,j+1];
    }
}
Console.WriteLine();

PrintArr(finalArray);