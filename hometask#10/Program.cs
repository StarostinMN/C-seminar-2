﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Пример: 456 -> 5, 782 -> 8, 918 -> 1*/
Console.Clear();
Console.WriteLine("Введите любое трехзначное число");
int numberWithSign = int.Parse(Console.ReadLine()); //Запоминаем введенное число с учетом знака
int number = Math.Abs(numberWithSign);//Приводим введенное число к положительному значению (если введено отрицательное)
int num1 = number / 100; //Выделяем первую цифру введенного числа
int num3 = number % 10;  //Выделяем третью цифру введенного числа
int num2 = (number - (num1 * 100 + num3)) / 10;//Выделяем вторую цифру введенного числа
//int num = signum * number;
Console.WriteLine($"Вторая цифра введенного числа {number * number / numberWithSign} равна {num2}");