// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


int ReadNumber(string message) 
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
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


int line = ReadNumber("Введите колличество строк: ");
int column = ReadNumber("Введите колличество столбцов: ");

int[,] array1 = GetMatrix(line, column);
int[,] array2 = GetMatrix(line, column);

if (array1.GetLength(0) != array2.GetLength(1))  // проверяем матрицы на возможность произведения
{
    Console.WriteLine("Невозможно произведение матриц!");
    return;
}

int[,] finalArray = new int[line, column];

for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            finalArray[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                finalArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }

Console.WriteLine("Первый массив: ");
PrintMatrix(array1);
Console.WriteLine();
Console.WriteLine("Второй массив: ");
PrintMatrix(array2);
Console.WriteLine();
Console.WriteLine("Массив с произведением элементов 1 и 2 массивов: ");
PrintMatrix(finalArray);