
//----------- Задача 1 --------------
// апишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

// Console.Write("Введите число X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("1");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("2");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("4");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("3");
// }
// else
// {
//     Console.WriteLine("Введено x = 0 и y = 0");
// }

// Задача №18. Работа в группах
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Write("Введите номер четверти: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == 1)
// {
//     Console.WriteLine("x > 0 и y > 0");
// }
// else if (number == 2)
// {
//     Console.WriteLine("x < 0 и y > 0");
// }
// else if (number == 3)
// {
//     Console.WriteLine("x < 0 и y < 0");
// }
// else if (number == 4)
// {
//     Console.WriteLine("x > 0 и y < 0");
// }
// else 
// {
//     Console.WriteLine("Введен некорректный номер четверти!");
// }

// Console.Write("Введите номер четверти, по которой хотите получить координаты: ");
// int number = int.Parse(Console.ReadLine());

// switch (number)
// {
//     case 1:
//     {
//        Console.WriteLine("В первой четверти значения х > 0, y > 0");
//        break; 
//     }
//     case 2:
//     {
//         Console.WriteLine("В первой четверти значения х < 0, y > 0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("В первой четверти значения х < 0, y < 0");
//         break;
//     }
//     case 4:
//     {
//        Console.WriteLine("В первой четверти значения х > 0, y < 0");
//        break;
//     }
    
//     default:
//     {
//         Console.WriteLine("Значение не верное");
//         break; 
//     }
// }

// Задача №20. Работа в группах
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double direction = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
Console.WriteLine($"Расстояние между точками в 2D пространстве: {direction}");

// Задача №22. Работа в группах
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    double powI = Math.Pow(i, 2);
    Console.Write($"{powI}, ");
}
Console.Write("\b\b ");