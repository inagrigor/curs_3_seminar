// // Задайте массив символов (тип char []). 
// Создайте строку из символов этого массива. 
// Пример [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// string GetStringFromCharArray(char[] array)
// {
//     //array = [a, b, c, d];
//    string result = string.Empty;// creiez un rind gol

//     foreach (char symbol in array)
//     {
//         result = result + symbol;//result += symbol == a+b ==ab
//     }
//     return result;
// }
// char[] chars = { '1', 'f', '4', '!', 'v' };
// Console.WriteLine($"Masiv:{string.Join(";", chars)}");
// string res = GetStringFromCharArray(chars);
// Console.WriteLine(res);


// Sarcina 2
// На основе символов строки (тип string) сформировать массив символов (тип char[]). 
// Вывести массив на экран. Указание Метод строки ToCharArray() не использовать. 
// Пример “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// char[] ConvertStringToCharArray(string str)
// {
//     char[] chars = new char[str.Length];
//     for (int i = 0; i < str.Length; i++)
//     {
//         chars[i] = str[i];
//     }
//     return chars;
// }
// string str = "Hello World!";
// Console.WriteLine($"String initial: {str}");
// char[] chars = ConvertStringToCharArray(str);
// Console.WriteLine($"Masiv: {string.Join("; " , chars)}");

//sarcina 3
// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
// Выяснить, сколько среди введённых букв гласных.  


// int GetVovelsCount(string str)
// {
//     string vovels = "aoeuyi";
//     int vovelsCount = 0;
//     foreach (char symbol in str)
//     {
//         foreach (char vovel in vovels)
//         {
//             if (symbol == vovel)
//             {
//                 vovelsCount++;
//                 break;
//             }

//         }
      
//     }
//       return vovelsCount;
// }
// Console.Write("Introduceti rindul: ");
// string inputString = Console.ReadLine();
// inputString = inputString.ToLower();
// Console.WriteLine($" In rindul: {inputString} in registrul jos : {GetVovelsCount(inputString)} litere vocale");




