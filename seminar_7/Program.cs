// Напишите программу, которая будет принимать на вход число 
//и возвращать сумму его цифр.
// int SumOfDigits(int number)
// {
//     if (number == 0)  return 0;
//     return number % 10 + SumOfDigits(number / 10);
// }
// int result = SumOfDigits(969);
// Console.WriteLine(result);

// //Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// void ShowNumbers(int start, int end)
// {
//     if(start == end) //1,2,3,4....(end = 5, dar nu il vedem, pentru ca sa-l vedem
//     //scrim Console.Write(start) unde start este egal cu end, dar end este egal cu 5)
//     {
//         Console.Write(start + " "); 
//         return; //return gol pentru ca este void
// }
// ShowNumbers(start + 1, end);//start = 1, end = 3,
// Console.Write(start + " ");


// //1
// //show 2,3
// //1,2
// //3,3
// //1,2,3
// }
// ShowNumbers(1, 5);