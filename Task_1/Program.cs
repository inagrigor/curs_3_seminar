﻿// Обычный комментарий 
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет
// тип_данных имяПеременной = значение;
//  int firstNumber = 25; // firstNumber = 30
// int secondNumber = 5; // secondNumber = 5
// // // "=": a = 30, присв.
// // // "==" - проверка на равенство: 5 == 5(true), 4 == 5 (false)
// // // "!="- проверка на НЕравенство: 4 == 5 (true). 5 == 5 (false)
//  if (firstNumber == secondNumber * secondNumber)
// {
//  Console.WriteLine("Да"); // 1 число - это квадрат 2 числа
// }
//  else // 1 число НЕ является квадратом 2 числа
// {
// Console.WriteLine("Нет"); // 1 число НЕ является квадратом 2 числа
// }

// double a = 5;
// int b = 2;
// double res = a / b;

// Console.WriteLine("Результат деления " + a + " на " + b + " = " + res); 
// "Привет" + "Мир" ="ПриветМир" = конкатенация, процесс сложения строк 

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// int N = 2; 
// int negativeN = -N; // -4

// while (negativeN <= N)
// {
//     Console.Write(negativeN + " "); 
//     negativeN++; // negativeN = negativeN + 1, increment
    // decrement: negativeN--(negativeN = negativeN - 1)
 //   }

 // Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10(4+6)
// 782 => 9
// 918 => 17

 int number = 357;
if (number >= 100 && number <= 999) // 100...999
// && - "si"
// % - остаток  от деления
 {
    int firstDigit = number / 100; // 357 / 100 = 3
     int thirdDigit = number % 10; // 357 % 10 = 7
      Console.WriteLine("Результат: " + (firstDigit + thirdDigit));
}
else
{
   Console.WriteLine("Error!");
    }
