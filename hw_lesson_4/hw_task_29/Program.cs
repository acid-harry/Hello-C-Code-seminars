// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
int Read (string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}

int [] Num  = new int[8];
int i = 0 ;
 while (i < Num.Length)
 {
 int NumberA = Read("Введите любое число: ");
 Num[i] = NumberA;
 i++;
 }
 Console.WriteLine("Создан новый массив: ");
 i = 0;
 while (i < Num.Length)
 {
    Console.Write(Num[i]+"  ");
 i++;
 }