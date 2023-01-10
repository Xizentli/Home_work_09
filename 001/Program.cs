/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

//метод введения числа с консоли
int GetNumberInConsole(string message)
{
    int result = 0;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число.");
        }
    }
    return result;
}

string GetNumbers(int n, int m)
{
    if(m == n)
    {
        return m.ToString();
    }
    else
    {
        return GetNumbers(n,m+1)+$", {m}";
    }
}

int numberN = GetNumberInConsole("Введите число N: ");
int numberM = 1;
Console.WriteLine(GetNumbers(numberN,numberM));
