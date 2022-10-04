// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] arr( int size , int minN , int maxN)
{
    int[] array = new int[size];
    Random Numb = new Random();
    for(int i = 0 ; i < size ; i++)
    {
        array[i] = Numb.Next(minN , maxN +1);
    }
    return array;
}
int negativeIndex(int [] array)
{
    int summ = 0;
    for ( int i = 0 ; i < array.Length ; i++ )
    {
        if (i % 2 != 0 )
        {
            summ +=array[i];
        }
    }
    return summ;
}
Random size = new Random();
Random LRange = new Random();
Random RRange = new Random();
int[] Number = arr(size.Next(3 , 15) , LRange.Next(-50 ,-30 ) , RRange.Next(0 , 100));
int NegSumm = negativeIndex(Number);
Console.WriteLine(string.Join(", ",Number));
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {NegSumm}");