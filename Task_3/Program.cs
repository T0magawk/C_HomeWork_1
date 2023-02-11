// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите любое число для проверки");
int n = int.Parse(Console.ReadLine ()!);
// int a = 0;
int count = 2;

while(count <= n)
{
    Console.WriteLine(count);
    count = count + 2;
}
//if (n % 2 == 0)
//{
//    Console.WriteLine("Это число четное, все его четные:");
  //  a = n;
  //  while (count > a)
  //  {
  //      Console.WriteLine(count );
  //      count = count + 2;
  //  }    
  //  Console.WriteLine(count );
//}

//else
//{
//    Console.WriteLine("Это число нечетное, все его четные:");
//    a = n-1;
//    Console.WriteLine(count );
//    
//    while (count > a)
//    {   
//        count = count + 2;
//        Console.WriteLine(count );
//        
//    }    
//
//}
 //Console.WriteLine(a);
