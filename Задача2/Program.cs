/* Задача 2: Напишите программу, 
которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Write("Введи число A : ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введи число B : ");
int numberB = int.Parse(Console.ReadLine()!);
if (numberA > numberB)
{
    Console.Write("Число А больше числа B");
}
else if (numberB > numberA)
{
    Console.Write("Число B больше числа A");
}
else
{
    Console.Write("Число А равно числу B");
}