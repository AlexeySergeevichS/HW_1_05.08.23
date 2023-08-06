/* Задача 8: Напишите программу, 
которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write("Введи число N: ");
int Number = int.Parse(Console.ReadLine()!);
if (Number >= 2)
{
    int i = 2;
    while (i <= Number - 2)
    {
        Console.Write($"{i}, ");
        i = i + 2;
    }
    Console.Write(i);
}
else
{
    Console.Write($"Четных чисел от 1 до {Number} нет.");
}
