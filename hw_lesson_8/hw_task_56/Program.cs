// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] GetMatrix(int rowsCount, int columnCount, int leftRange = 0, int rightRange = 99)
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
void MinSummElement(int[,] array)
{
    int minSum = 0;
    int minLine = 0;
    int sumLine = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum = minSum + array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumLine += array[i, j];
        if (sumLine < minSum)
        {
            minSum = sumLine;
            minLine = i;
        }
        sumLine = 0;
    }
    Console.Write($"{minLine + 1} строка с наименьшей суммой элементов, сумма элементов составляет: {minSum}");
}


int[,] array = GetMatrix(3, 5);
PrintMatrix(array);
Console.WriteLine();
MinSummElement(array);
