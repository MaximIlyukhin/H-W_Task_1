﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22



Console.Write("Enter a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter b = ");
int b = int.Parse(Console.ReadLine());
Console.Write("Enter c = ");
int c = int.Parse(Console.ReadLine());
if (a>b & a>c)
{
    Console.Write(a);   
}
else if (b>a & b>c)
{
    Console.Write(b);
}
else
{
    Console.Write(c);
}