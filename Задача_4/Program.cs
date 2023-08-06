/* Задача 4: Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Write("Введи количество чисел: ");
int NumberCount = int.Parse(Console.ReadLine()!);
int i = 0;
int[] Numbers = new int[NumberCount]; ;
while (i < NumberCount)
{
    Console.Write($"Введи число номер {i + 1}: ");
    Numbers[i] = int.Parse(Console.ReadLine()!);
    i++;
}
i = 1;
int max = Numbers[0];
while (i < NumberCount)
{
    if (Numbers[i] > max)
    {
        max = Numbers[i];
    }
    i++;
}
Console.Write($"Максимальное число это {max}");

