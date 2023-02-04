// Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[num];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 10);
}

PrintArr(arr);

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i],2}");
    }
}
int Sum(int[] arr)
{
    int max = arr[0];
    int min = arr[0];

    for (int i = 0; i < arr[i]; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return max - min;
}
Console.WriteLine();
Console.Write($"разница между максимальным и минимальным элементом массива равна {Sum(arr)}");
