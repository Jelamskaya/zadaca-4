﻿// Напишите программу, которая на вход принимает число(N), а на выходе
//показывает все четные числа от 1 до N.

Console.Clear();
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i < n; i++)
    Console.WriteLine($"{i}");