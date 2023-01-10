/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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

int GetAkkermanFunction (int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return GetAkkermanFunction(m - 1, 1);
    if(m > 0 && n > 0) return GetAkkermanFunction(m - 1, GetAkkermanFunction(m, n-1));  
    return -1; //ошибка
}

Console.WriteLine("Для вычисления функции Аккермана (А(m, n)) введине значения m и n.");
int numberM = GetNumberInConsole("Введите число m: ");
int numberN = GetNumberInConsole("Введите число n: ");

Console.WriteLine(GetAkkermanFunction(numberM, numberN));
