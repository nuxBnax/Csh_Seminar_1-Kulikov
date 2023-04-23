// Задача 2:

// Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Enter ANY number you want, PLEASE");
int number1 = Convert.ToInt32(System.Console.ReadLine());
Console.WriteLine("Enter ANOTHER number you want, PLEASE");
int number2 = Convert.ToInt32(System.Console.ReadLine());
int max = 0;
int min = 0;
if (number1 > number2)
{
    max = number1;
    min = number2;
}
else
{
    max = number2;
    min = number1;
}
Console.WriteLine("COOL, it's looks like: " + (max) + " > " + (min) );
Console.WriteLine("Then, we have: max" + " = " + (max));
