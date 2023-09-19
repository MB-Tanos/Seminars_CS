// // ctrl + /
//--------- Задача 1 ----------
//Напишите программу, которая на вход принимает 
//число и выдает его квадрат (число умноженное на само себя).
using System.Xml.Serialization;

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int str = number * number;

//Вывод построчно
Console.Write("Квадрат числа ");
Console.Write(number);
Console.Write(" равен = ");
Console.Write(str);
Console.WriteLine();

//Вывод с использованием $
Console.WriteLine($"Квадрат числа {number} равен = {str}");

//Вывод с обращением к переменным
Console.WriteLine("Квадрат числа {0} равен = {1}", number, str);

//Использование библиотеки Math
int sqr = Convert.ToInt32(Console.ReadLine());
double sqr_2 = Math.Pow(sqr, 2);
Console.WriteLine("Квадрат числа {0} равен = {1}", sqr, sqr_2);

//--------- Задача 2 ----------
//Напишите программу, которая на вход принимает 
//два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
//-------
bool c = a == b*b;
Console.WriteLine($"Является ли {a} квадратом {b} - {c}");
//-------
if (a == b*b){
    Console.WriteLine("Является");
}
else{
    Console.WriteLine("Не является");
}

//--------- Задача 3 ----------
//Напишите программу, которая будет выдавать 
//название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница
Console.WriteLine("Введите число от 1 до 7: ");
int numberDate = Convert.ToInt32(Console.ReadLine());
if (numberDate == 1){
    Console.Write("Понедельник");
}
else if (numberDate == 2) {
    Console.Write("Вторник");
}
else if (numberDate == 3) {
    Console.Write("Среда");
}
else if (numberDate == 4) {
    Console.Write("Четверг");
}
else if (numberDate == 5) {
    Console.Write("Пятница");
}
else if (numberDate == 6) {
    Console.Write("Суббота");
}
else if (numberDate == 7) {
    Console.Write("Воскресенье");
}
else{
    Console.WriteLine("Ваши данные некорректны. Введите число от 1 до 7");
}

//--------- Задача 4 ----------
//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int num = N*(-1);
//--------
if(N > 0){
    while(num <= N){
        Console.Write($"{num}, ");
        num++;
    }
}
else{
    while(N <= num){
        Console.Write($"{num}, ");
        N++;
    }
}
//--------
int num2 = Math.Abs(N) * (-1);
while(num2 <= N){
    Console.Write($"{num2}, ");
    num++;
}

//--------- Задача 5 ----------
//Напишите программу, которая принимает на вход трёхзначное число и на 
//выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

System.Console.WriteLine("Введите число: ");
int N_new = Convert.ToInt32(Console.ReadLine());
int ostatok = N_new % 10;

System.Console.WriteLine(ostatok);

//------
Console.Write("Введите число: ");
string numberStr = Console.ReadLine();
int amount = numberStr.Length;

Console.WriteLine(numberStr.Substring(amount-1));
