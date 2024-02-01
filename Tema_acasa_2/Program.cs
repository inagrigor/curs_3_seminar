
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

int x = 5;
int y = -3;
if (x > 0 && y > 0)
{
    Console.WriteLine("I Sfert de coordonate");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("III Sfert de coordonate");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("IV Sfert de coordonate");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("II Sfert de coordonate");
}
