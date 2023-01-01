// Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.


// void Recursion(int i)
// {
//     if (i == 0) return;
//     Recursion(i / 2);
//     if (i >= 1) Console.Write(i % 2);
// }

//     Console.Write("Enter num: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Recursion(n);


// void Recursion(int i)
// {  
//   if (i == 0) return;
//   Recursion(i / 2);
//   if (i % 2 == 1) Console.Write(1);
//   else Console.Write(0);
// }

// Console.Write("Enter num: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Recursion(n);

// Два метода, не знаю какой лучше, оставил оба.

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int Average(int i, int n)
// {
//      if (i < n)  return Average(i,n-1)+n;
//      else return n;
// }

//     Console.Write("Enter M: ");
//     int i = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Enter N: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     if (i > n){int o = i; i = n; n = o;}
//     int array = Average(i,n);
//     Console.Write(array);
