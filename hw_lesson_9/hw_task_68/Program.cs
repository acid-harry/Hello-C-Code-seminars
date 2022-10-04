// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadNumber(string message) // считываем M и N
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int m = ReadNumber("Введите первое  число(M): ");
int n = ReadNumber("Введите второе число(N): ");

int FunctionAkkerman(int m, int n) // функция Аккермана
{
   if(n < 0 || m < 0)
    {
        Console.WriteLine("Числа должны быть положительными!");
        return 0;
    }
    if(m == 0) 
    {
        return n + 1;
    }
    if(m > 0 && n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m , n - 1));
    }
}

void Akkerman(int m, int n)  //Метод вызова функции Аккермана
{   
    Console.WriteLine();
    Console.Write($"Функция Аккермана равна:");
    Console.WriteLine(FunctionAkkerman(m, n));
}

Akkerman(m, n);