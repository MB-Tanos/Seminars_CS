// ------------------ Задача 1 ---------------------- 
// Сортировка строк матрицы по возрастанию

using System;

public class Answer1
{
    public static void PrintMatrix(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                //Console.Write($"{matrix[i, j]}\t");
                Console.Write(string.Format("{0:0.00} ", matrix[i, j]));
            }
            Console.WriteLine();
        }
    }


    public static void SortRowsDescending(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {

            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                int minNum = matrix[i, j];
                int indexMin = j;
                for (int k = j; k < matrix.GetLength(1); k++)
                {
                    if (minNum > matrix[i, k])
                    {
                        minNum = matrix[i, k];
                        indexMin = k;
                    }                    
                }
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, indexMin];
                matrix[i, indexMin] = temp;            
            }                            
        }

    }

    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,] {
                {5, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                if (elements.Length != matrix.GetLength(1))
                {
                    Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
                    return;
                }
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        SortRowsDescending(matrix);

        Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
        PrintMatrix(matrix);
    }
}


// ------------------ Задача 2 ---------------------- 
// Определение строки с наименьшей суммой элементов

public class Answer2
{
    public static int SumOfRow(int[,] matrix, int row)
    {
        // Введите свое решение ниже
        int sum = matrix[row, 0];
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            sum += matrix[row, j];
        }
        return sum;
    }

    public static int[] MinimumSumRow(int[,] matrix)
    {
        int[] result = new int[2];
        int sum = SumOfRow(matrix, 0);
        int minRow = 0;
        for (int i = 1; i < matrix.GetLength(1); i++)
        {
            int sumOfRow = SumOfRow(matrix, i);
            if (sum > sumOfRow)
            {
                sum = sumOfRow;
                minRow = i;
            }
        }
        result[0] = minRow;
        result[1] = sum;
        return result;
    }

    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            // Если аргументы не переданы, используем матрицу по умолчанию

            matrix = new int[,]
            {
                {5, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

        int[] minSumRow = MinimumSumRow(matrix);

        Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");
    }
}


// ------------------ Задача 3 ---------------------- 
// Определение строки с наименьшей суммой элементов

public class Answer3
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    { 
        // Введите свое решение ниже
        if(matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            Console.WriteLine("It is impossible to multiply.");
            return;
        }
        MatrixMultiplication(matrixA, matrixB);

    }

    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {  
        // Введите свое решение ниже
        int[,] result = new int[matrixA.GetLength(0), matrixA.GetLength(1)];

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matrixB.GetLength(0); k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
                result[i, j] = sum;
            }
        }

        PrintMatrix(result);
        return result;
    }

    public static void PrintMatrix(int[,] matrix)
    {  
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
                //Console.Write(string.Format("{0:0.00} ", matrix[i, j]));
            }
            Console.WriteLine();
        }
    }
    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;

        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
                {5, 2},
                {8, 1}
            };

            // matrix = new int[,]
            // {
            //     {2, 4},
            //     {1, 3}, 
            //     {5, 6}
            // };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        int[,] matrixB = {
            {5, 6},
            {7, 8}
        };

        // int[,] matrixB = {
        //     {5, 6},
        //     {7, 8}
        // };

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMultiplication result:");

        MultiplyIfPossible(matrix, matrixB);
    }
}