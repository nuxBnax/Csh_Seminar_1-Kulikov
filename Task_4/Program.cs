// Задача 4:

// Напишите программу, которая принимает
// на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter First number you want, PLEASE");
int num1 = Convert.ToInt32(System.Console.ReadLine());
Console.WriteLine("Enter Second number, PLEASE");
int num2 = Convert.ToInt32(System.Console.ReadLine());
Console.WriteLine("Enter Third number WE need, PLEASE. It's OK, we almost there. :)");
int num3 = Convert.ToInt32(System.Console.ReadLine());
int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine("COOL, it's looks like: " + "max" + " = " + (max));


