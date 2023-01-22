// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();
int count = num.Length;

if(count == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.Write("число " + num + " является палиндромом");
    }
    else
    {
        Console.Write("число " + num + " не является палиндромом");
    }
}
else
{
    Console.Write("введено неверное значение");
}
