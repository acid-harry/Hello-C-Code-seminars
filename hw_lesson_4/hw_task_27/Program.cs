// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Read (string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}
int sum (int a )
{
    int summ = 0;
    if (a > 0 )
    {
        for (int i = a; i > 0; i= i / 10)
        {
            int deg =  i % 10;
            summ = summ + deg;
        }
    return summ;
    }
else
{
Console.WriteLine("Введите положительное число!");
return -1;
}
}
int NumberA = Read("Введите положительное число: ");
int summA = sum(NumberA);
Console.WriteLine($"Сумма цифр в числе {NumberA} = {summA}");