﻿
//Напишите программу, которая принимает на вход  трёхзначное число и удаляет вторую цифру этого числа.
// Примеры 
// a = 256 => 26 
// a = 891 => 81
// int number = 891;
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int result = firstDigit * 10 + thirdDigit;
// Console.WriteLine($" cifra {number} se transforma in {result}");

// Напишите программу, которая принимает на вход трёхзначное число и 
// возводит вторую цифру этого числа в степень, равную третьей цифре. 
// Примеры 
// 487 => 8^7 = 2 097 152 
// 254 => 5^4 = 625 
// 617 => 1
// int number = 617;
// int firstDigit = number / 100;
// int secondDigit = number / 10 % 10;
// int thirdDigit = number % 10;
// int result = (int)Math.Pow(secondDigit, thirdDigit);

// Console.WriteLine($" {secondDigit} ^ {thirdDigit} = {result}");

// Напишите программу, которая выводит третью  цифру c конца заданного 
// числа или сообщает, что третьей цифры нет. 
// 456  =>  4 
// 7812  =>  8 
// 91  =>  Третьей цифры нет

// int number = 91;
// if (number >= 100)
// {
//     int result = number / 100 % 10;
//     Console.WriteLine($"A III -a cifra din urma: {result}");
// }
// else 
// {
// Console.WriteLine("nu este a III -a cifra");
// }

