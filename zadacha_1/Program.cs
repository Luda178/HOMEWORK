﻿// Напишите программу, которая на вход принемает два числа и выдаёт,какое число больше а какое меньше
//a=5;b=7->max 7; a=2:b=10-> max 10; a=-9:b=-3 max -3;


Console.Clear();
Console.Write("Введите первое число: ");
int num1= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1>num2)
{
    Console.WriteLine("Первое число больше вторго");
}
if(num1<num2)
{
    Console.WriteLine("Первое число меньше вторго");
}
