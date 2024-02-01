
// SARCINA I
// Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23
// a=50   => нет
// a=7    => нет
// a=322  => да

// int a = 322;
// if (a % 7 == 0 && a % 23 == 0)
// {
//     Console.WriteLine("a este multiplu 7 si 23");
// }
// else
// {
//     Console.WriteLine("a nu este multiplu 7 si 23");
// }

// SARCINA II
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.
// 2,  3    =>   1
// -5, 3    =>   2
// -3, -2   =>   3 
// 4, -2    =>   4

// int x = -2;
// int y = -3;
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("I sfert de coordonate");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("II sfert de coordonate");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("III sfert de coordonate");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("IV sfert de coordonate");
// }

// SARCINA III
//  Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает 
//  наибольшую цифру числа.

//  40  => 4 
//  96  => 9 
//  72  => 7

// int number = 72;
// int firstDigit = number / 10; 
// int secondDigit = number % 10; 
// int max = firstDigit;


//  if (max < secondDigit)
//  {
//     max = secondDigit;
//  }

// {
//     Console.WriteLine(max);
// }

// Varianta II, Sarcina 3

// int number = 96;
// int firstNumber = number / 10;
// int secondNumber = number % 10;
// if (firstNumber > secondNumber)
// {
//     Console.WriteLine(firstNumber);
// }
// else
// {
//     Console.WriteLine(secondNumber);
// }


// SARCINA 4
// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

// 568  => 5,6,8 
// 8    => 8 
// 9542 => 9,5,4,2

// int N = 9;
// int divizor = 1;
// int currentDigit = N % 10;

// while (N / divizor >= 10)
//     {
//         divizor = divizor * 10;
//     }
       
// while (divizor >= 1)
// {
//     currentDigit = (int)(N / divizor);
//     Console.Write(currentDigit);
//     N = N % divizor;
//     divizor = divizor / 10;
//     if (divizor > 0) 
//      {
//         Console.Write(",");
//     }

// }

       

