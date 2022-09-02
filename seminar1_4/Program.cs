// 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.:

Console.Write ("Введите первое числа, мы определим какое из них больше:");
int a =  Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число:");
int b =  Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите третье число:");
int c =  Convert.ToInt32(Console.ReadLine());

int maxNubmer = a;
if (b > maxNubmer) maxNubmer = b;
if (c > maxNubmer) maxNubmer = c;
Console.Write ("Это число больше:");
Console.WriteLine (maxNubmer);