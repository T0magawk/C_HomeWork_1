//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите любое число для проверки");
int a = int.Parse(Console.ReadLine ()!);

if (a % 2 == 0)
{
    Console.WriteLine("Это число четное");
}
else
{
    Console.WriteLine("Это число нечетное");
}
