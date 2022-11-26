// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();

Console.Write("Введите первое число: ");            //просим ввести первое число
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");            //просим ввести второе число
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");            //просим ввести третье число
int number3 = int.Parse(Console.ReadLine());

int[] arr = {number1, number2, number3};

Console.WriteLine("Максимальное число: " + arr.Max());



//Метод номер № 1
// if (number1 > number2 && number1>number3)
// {
//         Console.WriteLine($"Максимальное число {number1}");
//     }
// if (number2 > number1 && number2>number3)
// {
//         Console.WriteLine($"Максимальное число {number2}");
//     }
// if (number3 > number1 && number3>number2)
// {
//         Console.WriteLine($"Максимальное число {number3}");
//     }