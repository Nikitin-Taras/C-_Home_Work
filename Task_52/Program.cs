// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int row = 3;
int col = 3;

double[,] arr = new double[row, col];

FillArray(arr);
PrintArr(arr);
Console.Write($"Среднее арифметическое значение в столбцах = ");

for (int j = 0; j < arr.GetLength(1); j++)
{
    double avg = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        avg = (avg + arr[i, j]);
    }
    avg = avg / row;
    Console.Write(avg + "; ");
}
Console.WriteLine();


 

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArr(double[,] arr)
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
 

