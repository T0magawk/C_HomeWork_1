// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine ()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine ()!);
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine ()!);
int m = 0;

if (a > b) 
m = a;
else m = b;

if (c > m)
m = c;

Console.WriteLine("Максимальное число");
Console.WriteLine(m);

