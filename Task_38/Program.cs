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

void PrintArr(int[] arry)
{
    for (int i = 0; i < arr.Length; i++)
    {
         Console.Write($"{arry[i], 2}");
    }
}
int Sum(int[] arry)
{
    int result = 0;
    int max = 0;
    int min = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = i;
        }
        else if (arr[i] < max)
        {
            min = i;
        }

     result = (max - min);   
    }
    return result;
}
Console.WriteLine();
Console.Write($"разница между максимальным и минимальным элементов массива равна {Sum(arr)}");
