//------------------------ 1 --------------------------
// Напишите программу, которая подсчитывает количество 
// четных элементов в массиве целых положительных трехзначных чисел и 
// выводит результат на экран.

using System;

public class Answer
{
    public static int CountEvenElements(int[] array)
    { 
    // Введите свое решение ниже
      int result = 0;
      for (int i = 0; i < array.Length; i++)
      {
          if(array[i] % 2 == 0)
          {
            result++;
          }
      }
      Console.WriteLine();
      return result;

    }

    public static void PrintArray(int[] array)
    {
    // Введите свое решение ниже
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write($"{array[i]}\t");    
      }

    }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        Console.WriteLine("Массив:");
        PrintArray(array);
        int evenCount = CountEvenElements(array);
        Console.WriteLine($"Количество четных элементов: {evenCount}");
    }
}

//------------------------ 2 --------------------------
// Напишите программу, которая находит сумму элементов с нечетными 
// индексами в одномерном массиве целых чисел и выводит результат на экран.

public class Answer2
{
    public static int SumOddElements(int[] array)
    {
// Введите свое решение ниже
      int result = 0;
      for (int i = 0; i < array.Length; i++)
      {
          if(i % 2 == 1)
          {
            result += array[i];
          }
      }
      Console.WriteLine();
      return result;

    }

    public static void PrintArray(int[] array)
    {
         // Введите свое решение ниже
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write($"{array[i]}\t");    
      }

    }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        PrintArray(array);
        int sumOdd = SumOddElements(array);
        Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
    }
}

//------------------------ 3 --------------------------
// Разница между максимальным и минимальным элементами массива

public class Answer3
{
    public static double FindMax(double[] array)
    {     
      // Введите свое решение ниже
      double max = array[0];
      for (int i = 0; i < array.Length; i++)
      {
          if(max < array[i])
          {
            max = array[i];
          }
      }
      return max;     
    }

    public static double FindMin(double[] array)
    {     
      // Введите свое решение ниже
      double min = array[0];
      for (int i = 0; i < array.Length; i++)
      {
          if(min > array[i])
          {
            min = array[i];
          }
      }
      return min; 
    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    {
      // Введите свое решение ниже
      double min = FindMin(array);
      double max = FindMax(array);
      return (max-min);
    }

    public static void PrintArray(double[] array)
    {
      // Введите свое решение ниже
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write($"{array[i]}\t");    
      }
      Console.WriteLine();
    }
 // Не удаляйте и не меняйте метод Main! 


    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3, 7.4, 22.3, 2, 78 };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}