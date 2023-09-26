using System;
// --------------- Задача 1 -------------
// Проверка на то, является ли число палиндромом 
public class Answer
{
    static bool IsPalindrome(int number)
    {
        // Введите свое решение ниже
        string numStr = number.ToString();
        if (numStr.Length != 5)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }
        else
        {
            for (int i = 0; i < numStr.Length / 2; i++)
            {
                if (numStr[i] != numStr[numStr.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}

// --------------- Задача 2 ---------------
// Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает 
// на вход координаты двух точек pointA и pointB в виде массива целых чисел, и 
// возвращает расстояние между ними в 3D пространстве.

public class Answer2
{
    private static double Length(int[] pointA, int[] pointB)
    {
        // Введите свое решение ниже
        double result = 0;
        for (int i = 0; i < pointA.Length; i++)
        {
            result = result + Math.Pow(pointA[i] - pointB[i], 2);
        }
        return Math.Sqrt(result);
    }

    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6)
        {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
        Console.WriteLine($"{result:F2}");
    }
}

// --------------- Задача 3 ---------------
// Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и выводит 
// таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

public class Answer3
{
   static void ShowCube(int N)
    {
      for(int i = 1; i <= N; i++)
      {
        Console.WriteLine(Math.Pow(i, 3));
      }
        
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}