/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] array = new int[4, 4];

int[,] FillArraySpiral(int[,] array) // Каким-то чудом заработало!
{
    int i = 0;
    int j = 0;
    for (int k = 1; k <= array.GetLength(0) * array.GetLength(1); k++)
    {
        array[i, j] = k;
        if (i <= j + 1 && i + j < array.GetLength(0) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

PrintArray(FillArraySpiral(array));