// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги

int Read (string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}
int degree (int a , int b)
{
    int summ = 1;
    if (b > 0 )
    {
        for (int i = 1; i <= b; i++)
        {
            summ = a * summ;
        }
    return summ;
    }
else
{
Console.WriteLine("Степень должна быть больше 0!");
return -1;
}
}
int NumberA = Read("Введите число , которое будет возводиться в степень: ");
int NumberB = Read("Введите степень числа (больше 0): ");
int sum = degree(NumberA , NumberB);
Console.WriteLine($"Число {NumberA}, в степени {NumberB} = {sum}");