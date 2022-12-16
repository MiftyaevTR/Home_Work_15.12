// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Просьба ввести число №1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Просьба ввести число №2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{
    Console.WriteLine("Число "+  num1 + " Больше");
    Console.WriteLine("Число "+  num2 + " Меньше");
}
else
{
    Console.WriteLine("Число "+  num2 + " Больше");
    Console.WriteLine("Число "+  num1 + " Меньше");
}
