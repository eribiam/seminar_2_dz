// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Нужно сделать через числа, без индексов строк.

// System.Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if ((number / 10) < 10 || (number / 10) >= 100 )
// {
//     System.Console.WriteLine("Это не трёхзначное число");
// }
// else 
// {
//     System.Console.Write("Вторая цифра = ");
//     System.Console.WriteLine((number / 10) % 10);
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if ((number / 10) < 10) System.Console.WriteLine("Третьей цифры нет");
// else 
// {
//     string numberString = Convert.ToString(number);
//     System.Console.WriteLine($"Третья цифра = {numberString[2]}");
// }

// Ввариант 2

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if ((number / 10) < 10) System.Console.WriteLine("Третьей цифры нет");
// else
// {
//     while (number > 999) number = number / 10;
//     number = number % 10;
//     System.Console.WriteLine($"Третья цифра = {number}");
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// System.Console.WriteLine("Введите цифру от 1 до 7: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (1 <= day && day <= 5) System.Console.WriteLine("Это не выходной");
// if (6 <= day && day <= 7) System.Console.WriteLine("Это выходной");
// if (day < 1 || day > 7) System.Console.WriteLine("Дней недели всего 7");