// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
if(NumberA <100 || NumberA > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}
else
{
    int dest = NumberA / 10;
    int res = dest % 10;
     Console.WriteLine(res);
}