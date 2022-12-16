// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
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
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Pls inter a number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Pls inter a number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Pls inter a number3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max_num = 0;


if (num1>num2 && num1>num3)
{
    max_num= num1;
}
if (num2>num1 && num2>num3)
{
    max_num= num2;
}
if (num3>num2 && num3>num1)
{
    max_num= num3;
}
Console.WriteLine("The max number is "+  max_num);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Просьба ввести число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Число чётное!");
}
else
{
    Console.WriteLine("Число не чётное!");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Просьба ввести число: "); 

int num = Convert.ToInt32(Console.ReadLine());

int start = 1;

while (start<= num)
{
    if (start % 2 ==0)
    {
        Console.Write(start + " " );
    }
    start += 1;
}

