﻿// // Задания из семинара
// // Первое задание
// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine()!);

// // int b = a * a;
// int squaredNumber = Convert.ToInt32(Math.Pow(number, 2));

// Console.WriteLine("Квадрат заданного числа = "  + squaredNumber);

// // Второе задание
// Console.WriteLine("Введите номер дня недели");
// int numberWeakDay = int.Parse(Console.ReadLine()!);

// switch (numberWeakDay)
// {
//     case 1: Console.WriteLine("Понедельник");
//             break;
//     case 2: Console.WriteLine("Вторник");
//             break;
//     case 3: Console.WriteLine("Среда");
//             break;
//     case 4: Console.WriteLine("Четверг");
//             break;
//     case 5: Console.WriteLine("Пятница");
//             break;
//     case 6: Console.WriteLine("Суббота");
//             break;
//     case 7: Console.WriteLine("Воскресенье");
//             break;
//     default: Console.WriteLine("В недели всего 7 дней");
//             break;
// }



// // Третье задание
// Console.WriteLine("Введи число");

// int n = int.Parse(Console.ReadLine()!);

// int i;
// if (n > 0) {

//     i = n - n - n;  

// } else {
//     i = n;
//     n = n - n - n;
// }

// Console.Write("\"");
// while (i<n)
// {
//     Console.Write($"{i}, ");
//     i++;
// }
// Console.Write(i);
// Console.Write("\"");

//Переменные для ДЗ

int number1, number2;

// Домашнее задание

Console.WriteLine();
Console.WriteLine("Задача №2.");
Console.WriteLine();

Console.Write("Введите первое число: ");
number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
number2 = int.Parse(Console.ReadLine()!);

if (Math.Equals(number1,number2)) Console.WriteLine("Введенные числа равнозначны");
else if (number1 > number2) Console.WriteLine("Первое число больше второго");
else Console.WriteLine("Втроре число больше первого");