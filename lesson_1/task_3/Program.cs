﻿// 3. напишите программу, которая будет выдавать название дня недели по заданному номеру дня недели.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели:");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 1) 
{
    Console.WriteLine("Понедельник");
}
else if(number == 2) 
{
    Console.WriteLine("Вторник");
}
else if(number == 3) 
{
    Console.WriteLine("Среда");
}
else if(number == 4) 
{
    Console.WriteLine("Четверг");
}
else if(number == 5) 
{
    Console.WriteLine("Пятница");
}
else if(number == 6) 
{
    Console.WriteLine("Суббота");
}
else if(number == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("В неделе всего лишь 7 дней(");
}