// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// // Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// while (true) // un ciclu infinit
// {
//     Console.Write("Introduceti un numar sau litera 'q' pentru iesire:");
//     string text = Console.ReadLine();
//     if (text == "q")
//     {
//         break;
//     }
//     int number;
//     if (int.TryParse(text, out number))//verificare daca "text" este alcatuit numai din cifre, 
//     //rezultatul se compara cu number de mai sus prin parametrul out
//     {
//         int sum = 0;
//         while (number > 0)
//         {
//             sum = sum + number % 10; // adaugam ultima cifra din numar (234/10 => rest (4 = ultima cifra))
//         number = number / 10; // aflam a doua cifra din urma din numar eliminind ultima (234 / 10 => 3)
//     }
//         if (sum % 2 == 0) // verificam daca sum este un numar par
//         {
//             Console.WriteLine("[Stop]");
//             break;
//         }
//     }
//     else //cind cind nu esti nici numar nici litera "q"
//     {
//         Console.WriteLine("nu este introdus nici simbolul nici cifra corecta. Introduceti sau int sau 'q'");
//     }
// }

// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


// int[] array = new int[30];
// Random rnd = new Random();
// int evenCount = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rnd.Next(100, 1000);
//     Console.Write(array[i] + " ");

//     if (array[i] % 2 == 0)
//     {
//         evenCount++;
//     }
// }
// Console.WriteLine($"Un numar de cifre pare in masiv: {evenCount}");

// Console.WriteLine("Hello, World!");

//  Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
// [1 3 5 6 7 8] => [8 7 6 5 3 1]  
// int[] array = { 1, 3, 5, 6, 7, 8 };
// int temp;
// Console.Write("Masivul initial: ");
// foreach (int e in array)
// {
//     Console.Write(e + " ");
// }
// for (int i = 0; i < array.Length / 2; i++)
// {
//     temp = array[i];
//     array[i] = array[array.Length - 1 - i];
//     array[array.Length - 1 - i] = temp;
// }
// Console.Write("Un masiv reversat: ");
// foreach (int e in array)
// {
//     Console.Write(e + " ");
// }