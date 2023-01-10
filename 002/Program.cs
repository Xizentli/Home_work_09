/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

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

int GetSumNumbers(int m, int n, int sumNumber)
{
    if(m == n+1)
    {
        return sumNumber;
    }
    else
    {
        sumNumber += m;
        return GetSumNumbers(m+1, n, sumNumber);
    }
}

Console.WriteLine("Для подсчета суммы элементов от M до N необходимо задать границы промежутка.");
int numberM = GetNumberInConsole("Введите число M: ");
int numberN = GetNumberInConsole("Введите число N: ");
int sumNumber = 0;
Console.WriteLine(GetSumNumbers(numberM, numberN, sumNumber));
