// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//y-y = k1*x +b1-(K2*x+b2) / 0 = k1*x +b1 - k2*x - b2

double Read (string message)
{
Console.WriteLine(message);
return (Convert.ToDouble(Console.ReadLine()));
}
double b1 = Read("Введите координату b1");
double k1 = Read("Введите координату k1");
double b2 = Read("Введите координату b2");
double k2 = Read("Введите координату k2");
double x = (b1-b2)/(k2-k1);
double y = k2 * x + b2;
Console.WriteLine($"Координата точки пересечения двух прямых х:{x} ; y:{y}");