// Задача 8: 

// Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Enter ANY number you want, I'll name it N!");
int N = Convert.ToInt32(System.Console.ReadLine());
int count = 1;
Console.WriteLine("Your EVEN numbers from 1 to N will be:");
while (count <= N)
{
    if (count % 2 == 0)
    {
        Console.Write((count) + " ");
    }
    count++;
}