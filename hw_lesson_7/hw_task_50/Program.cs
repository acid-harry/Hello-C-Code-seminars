// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] GetMatrix(int rowsCount = 5, int columnCount = 5, int leftRange = -100, int rightRange = 100)
{
    int[,] matrix = new int[rowsCount, columnCount];
    Random rand = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange +1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.WriteLine();
    }
}

int line = ReadNumber("Введите номер строки позиции элемента: ");
int column = ReadNumber("Введите номер столбца позиции элемента: ");
int[,] matr = GetMatrix();
PrintMatrix(matr);
Console.WriteLine();
int number = 0;
if(line > matr.GetLength(0) || column > matr.GetLength(1))
{
    Console.WriteLine("Колличество сток/столбцов не может превышать колличество строк/столбцов в массиве!");
}
else if(line <= 0 || column <= 0)
{
    Console.WriteLine("Колличество сток/столбцов не может иметь отрицательное значение или равняться нулю!");
}
else
{
    number = matr[line -1, column -1];
    Console.WriteLine($"Нужный элемент массива: {number}");
}