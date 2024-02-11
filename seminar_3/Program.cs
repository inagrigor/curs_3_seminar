// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
//Программа должна выдать ответ: Да/Нет. 
//Примеры 
//[1 3 4 19 3], 8 => Нет 
//[-4 3 4 1], 3 => Да

// int[] array = { 1, 3, 4, 19, 3 };
// int numberForSearch = 8;


// for (int i = 0; i < array.Length; i++)
// {
//     if (numberForSearch == array[i])
// {
//     Console.WriteLine("Da");
//     break;
// }
// else
// {
//     Console.WriteLine("Nu");
// }
// }
// Pentru ca in rezultat sa nu dee o multime de raspunsuri DAR unul singul aplicam urmatorul algoritm
// int[] array = { 11, 31, 8, 19, 31 };
// int numberForSearch = 8;
// bool isFound = false; // numarul nu este gasit
// for (int i = 0; i < array.Length; i++)
// {
//     if (numberForSearch == array[i])
//     {
//         isFound = true;
//         break;
//     }
// }
//    if (isFound) // isFound == true
//     {
//         Console.WriteLine("Da");
//     }
//     else
//     {
//         Console.WriteLine("Nu");
//     }

// Sarcina 2
// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. 
// Замените отрицательные элементы на положительные, а положительные на отрицательные. 
// Пример 
// [1 -5 6] => [-1 5 -6]
// int[] array = { -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] *= -1; // array[i] = array[i] * -1; 
//     //a = a + 20 (a += 20), b = b - 120 (b -= 120), c = c / -1 (c /= -1)
// }
// Console.WriteLine($"Masiv: [ {string.Join("; ", array)} ]");

//Sarcina 3
// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новый массив. 
// Пример 
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

int[] array = [2, 3, 1, 7, 5, 6, 3];
int[] result = new int[array.Length / 2];

for (int i = 0, j = array.Length - 1; i < result.Length; i++, j--)
{
    result[i] = array[i] * array[j];
}
Console.WriteLine($"result: [ {string.Join("; ", result)} ]");

