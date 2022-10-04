// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
if(NumberA < 1 || NumberA >7)
{
    Console.WriteLine("В неделе 7 дней , такого дня не существует");
}
else if(NumberA == 6 || NumberA == 7)
{
    Console.WriteLine($"{NumberA} день недели выходной");
}
else
{
    Console.WriteLine($"{NumberA} день недели НЕ выходной");
}