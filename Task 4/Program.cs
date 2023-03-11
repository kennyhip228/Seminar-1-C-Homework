// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите натуральное число: ");
int a = int.Parse(Console.ReadLine());
while (a < 1)
{
    Console.WriteLine("Вы ввели неверное число");
    Console.Write("Введите натуральное число: ");
    a = int.Parse(Console.ReadLine());
}

for (int i = 2; i <= a; i = i + 2)
    Console.Write($"{i} ");