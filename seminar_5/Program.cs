//   Sarcina 1
// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты. 
// Оформить этапы в виде функций. Пример 
//
//int[,] CreateMatrix(int rows, int columns)
// {
//     int[,] matr = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matr.GetLength(0); i++) // row = GetLength(0)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) //columns = matr.GetLength(1);
//         {
//             matr[i, j] = rnd.Next(101);//
//         }
//     }
//     return matr;
// }
// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // row = GetLength(0)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) //columns = matr.GetLength(1);
//         {
//             Console.Write($"{matr[i, j]}\t"); //\t = 4 spatii inte elemente
//         }//am termonat vizitatrea rindului 0 mergem la rindul 1
//         Console.WriteLine();//trecerea la rindul nou
//     }
// }

// void SquareElements(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // row = GetLength(0)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matr[i, j] = matr[i, j] * matr[i, j];
//             } //matr[i,j] *= matr[i,j]
//         }
//     }
// }
// Console.Write("Introduceti un numar de rinduri: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Introduceti un numar de colonite: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = CreateMatrix(rows, cols);
// PrintMatrix(matrix);
// Console.WriteLine("Result: ");
// SquareElements(matrix);
// PrintMatrix(matrix);

// Console.WriteLine("Hello, World!");

//           Sarcina 2
// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// int[,] CreateMatrix(int rows, int columns)
// {
//     int[,] matr = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matr.GetLength(0); i++) // row = GetLength(0)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) //columns = matr.GetLength(1);
//         {
//             matr[i, j] = rnd.Next(101);//
//         }
//     }
//     return matr;
// }
// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // row = GetLength(0)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) //columns = matr.GetLength(1);
//         {
//             Console.Write($"{matr[i, j]}\t"); //\t = 4 spatii inte elemente
//         }//am termonat vizitatrea rindului 0 mergem la rindul 1
//         Console.WriteLine();//trecerea la rindul nou
//     }
// }
// int GetMainDiagonalSum(int[,] matr)
// {
//     int sum = 0;
//     for (int i = 0; i < matr.GetLength(0); i++) // row = GetLength(0)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum = sum + matr[i, j]; // sum += matr[i, j] 
//             }
//         }
//     }
//     return sum;
// }


// Console.Write("Introduceti un numar de rinduri: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Introduceti un numar de colonite: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = CreateMatrix(rows, cols);
// PrintMatrix(matrix);
// Console.WriteLine($"Result:{GetMainDiagonalSum(matrix)}");

//     sarcina 3
// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, 
// состоящий из средних арифметических значений по строкам двумерного массива. 

// 
//int[,] CreateMatrix(int rows, int columns)
// {
//     int[,] matr = new int[rows, columns]; // [стр, столбцы]
//     Random rnd = new Random();
//     for (int i = 0; i < rows; i++) // rows = matr.GetLength(0)
//     {
//         // j, m, k
//         for (int j = 0; j < columns; j++) // columns = matr.GetLength(1)
//         {
//             matr[i, j] = rnd.Next(101); // [0,100], (0, 101)
//         }
//     }
//     return matr;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // стр
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // столбцы
//         {
//             Console.Write($"{matr[i, j]}\t"); // "\t" = 4 пробела 
//         } // Закончили обход 0 строки, идем в 1
//         Console.WriteLine(); // Перенос на новую строчку
//     }
// }

// double[] GetArrayWithMeans(int[,] matrix)
// {
//     double[] means = new double[matrix.GetLength(0)];
//     // 1 2     means = [1.5, 0]
//     // 3 4
//     for (int i = 0; i < matrix.GetLength(0); i++) // стр
//     {
//         double currentSum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
//         {
//             currentSum += matrix[i, j]; // currentSum = currentSum + matrix[i,j] ]
//         }
//         double currentMean = Math.Round(currentSum / matrix.GetLength(1), 2);
//         means[i] = currentMean;
//     }
//     return means;
// }
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = CreateMatrix(rows, cols); // Матрица rows на cols
// PrintMatrix(matrix);
// double[] res = GetArrayWithMeans(matrix);
// Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");

// int[,] CreateMatrix(int rows, int columns)
// {
//     int[,] matr = new int[rows, columns]; // [стр, столбцы]
//     Random rnd = new Random();
//     for (int i = 0; i < rows; i++) // rows = matr.GetLength(0)
//     {
//         // j, m, k
//         for (int j = 0; j < columns; j++) // columns = matr.GetLength(1)
//         {
//             matr[i, j] = rnd.Next(101); // [0,100], (0, 101)
//         }
//     }
//     return matr;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // стр
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // столбцы
//         {
//             Console.Write($"{matr[i, j]}\t"); // "\t" = 4 пробела 
//         } // Закончили обход 0 строки, идем в 1
//         Console.WriteLine(); // Перенос на новую строчку
//     }
// }

// double[] GetArrayWithMeans(int[,] matrix)
// {
//     double[] means = new double[matrix.GetLength(0)];
//     // 1 2     means = [1.5, 0]
//     // 3 4
//     for (int i = 0; i < matrix.GetLength(0); i++) // стр
//     {
//         double currentSum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
//         {
//             currentSum += matrix[i, j]; // currentSum = currentSum + matrix[i,j] ]
//         }
//         double currentMean = Math.Round(currentSum / matrix.GetLength(1), 2);
//         means[i] = currentMean;
//     }
//     return means;
// }
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = CreateMatrix(rows, cols); // Матрица rows на cols
// PrintMatrix(matrix);
// double[] res = GetArrayWithMeans(matrix);
// Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");