
// int Calculate(int a, int b, string sign)
// {
//     if (sign == "+")
//     {
//         return a + b;
//     }
//     else if (sign == "-")
//     {
//         return a - b;
//     }
//     else if (sign == "*")
//     {
//         return a * b;
//     }
//     else
//     {
//         Console.WriteLine("Este introdus un semn de operatie aritmetica necunoscut");
//         return 0;
//     }
// }

// Console.WriteLine(Calculate(2, 3, "+"));
// Console.WriteLine(Calculate(2, 3, "-"));
// Console.WriteLine(Calculate(2, 3, "*"));
// Console.WriteLine(Calculate(2, 3, "."));

//Sarcina 1
// Задайте массив из N случайных целых чисел (N вводится с клавиатуры). 
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
//Пример [1 5 11 21 81 4 0 91 2 3]
// => 2 

// int[] CreatArray(int size)
// {

//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 101);
//     }
//     return array;
// }
// int GetCount(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 7 == 0 && array[i] % 10 == 1)
//         {
//             count++;
//         }

//     }
//     return count;
// }

// Console.WriteLine("introduceti numarul: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = CreatArray(N);
// Console.WriteLine($"Masiv: [ {string.Join("; ", array)} ]")
// // int count = GetCount(array);
// // Console.WriteLine(count);
// Console.WriteLine($"Result: {GetCount(array)}");

// Sarcina 2
// Заполните массив на  N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9. 
// Сформируйте целое число, которое будет состоять из цифр из массива.
//  Старший разряд числа находится на 0-м индексе, младший – на последнем. 
// Пример [1 3 2 4 2 3] => 132423 [2 3 1] => 231

// int[] CreatArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(10);
//     }
//     return array;
// }
// int ConvertArrayToInteger(int[] array)
// {
//     int result = 0;
//     for (int i = 0, j = array.Length - 1; i < array.Length; i++, j-- )
//     {
//         result = result + array[i] * (int)Math.Pow(10, j);
//     }
//     return result;
// }




// Console.WriteLine("introduceti numarul: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = CreatArray(N);//creat un massiv din elemente N
// Console.WriteLine($"Masiv: [ {string.Join("; ", array)} ]");
// Console.WriteLine($"Result: {ConvertArrayToInteger(array)}");

// Задача: Написать программу, которая из имеющегося массива строк формирует новый 
// массив из строк, длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
//[“Hello”, “2”, “world”, “:-0”] → [“2”, “:-0”]

// string[] ConvertStringArray(string[] array)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i].Length <= 3)
//         {
//             count++;
//         }
//     }
//     string[] arrs = new string[count];
//     int j = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i].Length <= 3)
//         {
//             arrs[j] = array[i];
//             j++;
//         }
//     }
//     return arrs;
// }


// string[] array = { "Hello", "2", "world", ":-0" };
// string[] arrs = ConvertStringArray(array);
// Console.WriteLine($"masiv: [{string.Join("; ", arrs)}]");


// //[“2”, “:-0”]
// //Console.WriteLine($"Masiv: [ {string.Join("; ", array)} ]")


// int GetCountStringInArray(string[] array)
// {
//     int countStrings = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i].Length <= 3)
//         {
//             countStrings++;
//         }
//     }
//     Console.WriteLine(countStrings);
//     return countStrings;
// }
// string[] ConvertStringArray(string[] array)
// {
//     string[] arrs = new string[countStrings];
//     int j = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] <= 3)
//         {
//             arrs[j] = array[i];
//             j++;
//         }
//     }
//     return arrs;
// }


// string[] array = { "Hello", "2", "world", ":-0" };
// string[] arrs = ConvertStringArray(array);
// Console.WriteLine($"masiv: [{string.Join("; ", arrs)}]");