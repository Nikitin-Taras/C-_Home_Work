﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int res = N%100;

Console.Write(res + "\b ");