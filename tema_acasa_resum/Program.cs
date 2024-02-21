// Задача 1: 
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы


// void ShowNumbers(int m, int n)
// {
//     if (m == n)
//     {
//         Console.Write(m + " ");
//         return;
//     }
//     Console.Write(m + " ");
//     ShowNumbers(m + 1, n);

// }
// Console.WriteLine("introduceti numarul m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("introduceti numarul n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// // ShowNumbers(m, n);
 

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 

// int A(int n, int m)
// {
//     if (n == 0) return m + 1;
//     if (n > 0 && m == 0) return A(n - 1, 1);

//     else return A(m - 1, A(m, n - 1));
// }

// int n = 1;
// int m = 1;

// Console.WriteLine($"A({n},{m}) = {A(n, m)}");

// Задача 3: Задайте произвольный массив. 
// // Выведите его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// int[] arr = new int[10];
// int j = arr.Length - 1;
// void PrintReverseArray(int[] arr, int j)
// {
//         if (j == 0)
//         {
//             Console.WriteLine(arr[j]);
//               return;
//         }    
//     Console.Write(arr[j] + ", ");
//     PrintReverseArray(arr, j - 1);
// }

// int[] array = { 1, 2, 5, 0, 10, 34, 3, 4, 8, 9 };
// PrintReverseArray(array, j);
// Console.WriteLine(array[j] + ", ");




