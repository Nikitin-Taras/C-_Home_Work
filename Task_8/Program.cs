//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите чило: ");
int N = Convert.ToInt32(Console.ReadLine());

int c = 2;


while (c <= N) 
{

    if (c % 2 == 0) 
    {
    Console.Write(c + " ");
    c += 2;
    }
}

