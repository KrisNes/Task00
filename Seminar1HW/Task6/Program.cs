﻿// Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдает является ли число чётным (делится ли оно на два без остатка).

// Например: 
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine()); 

if (a % 2 == 0)
{
    Console.WriteLine("Введенное число " + a + " четное");
}
else
{
    Console.WriteLine("Введенное число " + a + " не является четным");
}