﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Clear();

Console.Write("Введите первое число: ");            //просим ввести первое число
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");            //просим ввести второе число
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Большее число {number1} Меньше число {number2}");
}
    else
    {
        Console.WriteLine($"Большее число {number2} Меньше число {number1}");
    }
