// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите чило N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"N = {N} -> {SumNumbers(N,1)}");

string SumNumbers(int end, int start)
{
    if (end == start) return Convert.ToString(end);
    return (end + " " + SumNumbers(end - 1, start));
}