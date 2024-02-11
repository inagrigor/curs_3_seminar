
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
// Console.WriteLine($"Masiv: [ {string.Join("; ", array)} ]");
// // int count = GetCount(array);
// // Console.WriteLine(count);
// Console.WriteLine($"Result: {GetCount(array)}");
