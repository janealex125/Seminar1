﻿// 2.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.:

Console.Write ("Введите первое числа, мы определим какое из них больше:");
int a =  Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число:");
int b =  Convert.ToInt32(Console.ReadLine());
if (a > b)
{
Console.Write ("Это число больше:");
Console.WriteLine (a);
}
else
{
    Console.Write ("Это число больше:");
Console.WriteLine (b);
}