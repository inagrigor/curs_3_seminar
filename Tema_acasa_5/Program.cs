// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива. 
// Пример a b c   => “abcdef” d e f 
// char[,] charMatrix = new char[,]{ { 'a', 'b', 'c', 'd' }, { 'e', 'd', 'k','m' } };
// string GetStringFromCharMatrix(char[,] matrix)
// {
//     string result = string.Empty;// creiez un rind gol
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 result = result + matrix[i, j];
//             }
//         }
//     }
//     return result;
// }
// void PrintMatrix(char[,] chars)
// {
//   for (int i = 0; i < chars.GetLength(0); i++) 
//  {
//    for (int j = 0; j <chars.GetLength(1); j++) 
//    {
//   Console.Write($"{chars[i, j]}\t");
//    }
//       Console.WriteLine();
//  }
// }

// char[,] chars = { { 'a', 'b', 'c', 'd' }, { 'e', 'd', 'k', 'm' } };
// Console.WriteLine("Introduceti masivul:" );
//  PrintMatrix(chars);
// string result = GetStringFromCharMatrix(chars);
// Console.WriteLine(result);


// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные. 

// string row = "SeminarCuNumarulShase";
// string result =  row.ToLower();
// string res = row.ToUpper();
// Console.WriteLine(result);
// Console.WriteLine(res);

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом. 

// string str = "SeminarCuNumarulShase";
// bool checkPallindrome(string str)
// {
//     for (int i = 0; i < str.Length / 2; i++)
//     {
//         if (str[i] != str[str.Length - 1 - i])
//         {
//             return false;
//         }
//     }
//     return true;
// }
// bool a = checkPallindrome(str);
// Console.WriteLine(a);










// // Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// // Сформировать строку, в которой слова расположены в обратном порядке. 
// // В полученной строке слова должны быть также разделены пробелами. 
