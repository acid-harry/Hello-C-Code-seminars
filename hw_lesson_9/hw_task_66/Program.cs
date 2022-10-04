// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string message)  //метод считывания N
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int M = ReadNumber("Введите первое число:");
int N = ReadNumber("Введите второе число:");

void SummElements(int m, int n, int sum)
{   
    if(m < 0 || n < 0)
    {
        Console.WriteLine("Числа должны быть натуральными(положительными)!"); 
        return;
    }
    if(m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N}: {sum}"); 
        return;
    }
    sum = sum + (m++);
    SummElements(m, n, sum);
}

SummElements(M, N, 0);