// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите любое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
int i = 1;
while ( i <= num )
{
Console.Write(Math. Pow(i, 3) +" ");
i++;
}
}
else
{
Console.WriteLine("Вы ввели не положительное число!");
}