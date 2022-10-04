﻿// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int Read (string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}
int a = Read("Введите значение стороны A: ");
int b = Read("Введите значение стороны B: ");
int c = Read("Введите значение стороны C: ");
if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine($"Да , треугольник с сторонами {a}, {b}, {c} может существовать");
}
else
 Console.WriteLine($"Нет , треугольник с сторонами {a}, {b}, {c} существовать не может!");