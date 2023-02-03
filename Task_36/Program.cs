// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];
int sum = 0;

Console.Write("[");

for (int i = 0; i < num; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine("\b\b]");

for (int i = 0; i < num; i++)
{
    if (array[i] % 2 == 1)
    sum += array[i];
}
Console.WriteLine($"Сумма нечетных чисел = {sum}");