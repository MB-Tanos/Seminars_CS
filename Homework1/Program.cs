//-------------- Задача 2 --------------
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2){
    Console.WriteLine($"max = min = {num1}");
}
else if (num1 < num2){
    Console.WriteLine($"max = {num2}, min = {num1}");
}
else{
    Console.WriteLine($"max = {num1}, min = {num2}");
}
Console.WriteLine();

//-------------- Задача 4 --------------
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите число 1: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (max < num2){
    max = num2;
}
if (max < num3){
    max = num3;
}
Console.WriteLine($"Максимально число из введенных: {max}");
Console.WriteLine();

//-------------- Задача 6 --------------
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool temp = num % 2 == 0;
Console.WriteLine($"Является ли число {num} четным? Ответ: {temp}");
Console.WriteLine();

//-------------- Задача 8 --------------
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= num){
    Console.Write($"{i}, ");
    i += 2;
}