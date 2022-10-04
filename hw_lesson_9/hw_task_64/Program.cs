// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadNumber(string message)  //метод считывания N
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNTo1(int n) //метод вывода чисел от N до 1.
{   
    if(n < 0)
    {
        Console.WriteLine("Число не натуральное!");
        return;
    }
    if(n == 0)
    {
        return;
    }
    else
    {   
        Console.Write(n + " ");
        PrintNTo1(n - 1);

    }
}

int numberN = ReadNumber("Введите число: ");
PrintNTo1(numberN);