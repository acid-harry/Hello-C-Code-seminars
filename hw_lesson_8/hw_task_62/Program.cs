// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] arr = new int[4, 4];

void SpiralArray(int[,] arr)
{

    int m = 0;
    int n = 0;
    bool isItNewCircle = true;

    for (int i = 0; i < arr.Length; i++)
    {
        arr[m, n] = i + 1;

        if (n + 1 < arr.GetLength(1) && isItNewCircle && arr[m, n + 1] == 0)
        {
            n++;
            continue;
        }
        else
        {
            isItNewCircle = false;
        }
        
        if (m + 1 < arr.GetLength(0) && arr[m + 1, n] == 0)
        {
            m++;
            continue;
        }
        
        if (n - 1 >= 0 && arr[m, n - 1] == 0)
        {
            n--;
            continue;
        }
        
        if (m - 1 >= 0 && arr[m-1, n] == 0)
        {
            m--;
            continue;
        }
        else
        {
            n++;
            isItNewCircle = true;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

SpiralArray(arr);
PrintArray(arr);