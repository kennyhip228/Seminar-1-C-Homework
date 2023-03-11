// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
if (a>b & a>c)
    Console.WriteLine($"max = {a}");
else if (b>a & b>c)
    Console.WriteLine($"max = {b}");
else if (c>a & c>a)
    Console.WriteLine($"max = {c}");
else
    Console.WriteLine($"{a} = {b} = {c}");