
//Напишите программу, которая принимает на вход  трёхзначное число и удаляет вторую цифру этого числа.
// Примеры 
// a = 256 => 26 
// a = 891 => 81
int number = 891; 
int firstDigit = number /  100;
int thirdDigit = number % 10; 
int result = firstDigit * 10 + thirdDigit;
Console.WriteLine($" cifra {number} se transforma in {result}");