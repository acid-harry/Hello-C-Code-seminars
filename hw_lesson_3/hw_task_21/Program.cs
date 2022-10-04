// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X первой точки: ");
double X1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y первой точки: ");
double Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z первой точки: ");
double Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки: ");
double X2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y второй точки: ");
double Y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z второй точки: ");
double Z2 = Convert.ToInt32(Console.ReadLine());

double resx = Math.Pow((X2 - X1), 2);
double resy = Math.Pow((Y2 - Y1), 2);
double resz = Math.Pow((Z2 - Z1), 2);
double length = Math.Sqrt(resx + resy + resz);
Console.WriteLine(Math.Round(length , 2));