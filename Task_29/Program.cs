// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



Console.Write("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] mas = new int[num];
for (int i = 0; i < num; i++)
{
    mas[i]=new Random().Next(0,100);
}
for (int i = 0; i < num; i++)
{
    Console.Write("["+mas[i] + "]");
}