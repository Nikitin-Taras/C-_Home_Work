// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];
int count = 0;

Console.Write("[");

for (int i = 0; i < num; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine("\b\b]");

for (int i = 0; i < num; i++)
{
    if (array[i] % 2 == 0)
    count++;
}

Console.Write($"Количество четных чисел в массиве равно, {count}");