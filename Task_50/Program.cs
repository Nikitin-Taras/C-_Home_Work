// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
// 1 1 -> 9

Console.Write("Введите элемент строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элемент столбца: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[5, 5];

FillArray(arr);
PrintArr(arr); 

if(row < arr.GetLength(0) && col < arr.GetLength(1)) Console.WriteLine($"Содержимым элемента ({row},{col}) является {arr[row,col]}");
else Console.Write($"({row},{col}) - такого элемента нет в массиве");


void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 99);
        }
    }
}


void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 4}");
        }
        Console.WriteLine();
    }
}
 
