// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите чило M: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило N: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write(SumNumbers(M, N));

int SumNumbers(int a, int b)
{
    if (a == b) return (a);
    else if (a < b) return (b + SumNumbers(a, b - 1));
    return (b + SumNumbers(a, b + 1));
}