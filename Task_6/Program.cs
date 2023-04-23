// Задача 6: 

// Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно
// на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Enter ANY number you want, PLEASE!");
int num = Convert.ToInt32(System.Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("YES, the number you have gust entered is EVEN!");
}
else 
{
    Console.WriteLine("NO, the number you have gust entered is ODD!");
}
