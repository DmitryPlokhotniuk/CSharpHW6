/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7 */

int x = 3;
int y = 3;

int[,] FillArray (int x, int y)
{
    int[,] array = new int[x, y];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
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

int[] MinElement (int[,] array)
{
    int tmp = array[0, 0];
    int[] minElement = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < tmp)
            {
                minElement[0] = i;
                minElement[1] = j;
                tmp = array[i, j];
            }
        }
    }
    return minElement;
}

int[,] DeleteMin (int[,] array, int[] minElement)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != minElement[0] && j != minElement[1])
            {
                newArray[k, n] = array[i, j];
                n++;
            }
        }
        if (i != minElement[0])
        {
            k++;
        }
        n = 0;
    }
    return newArray;
}




int[,] array = FillArray(x, y);
int[] minElement = MinElement(array);
Console.WriteLine($"Адрес минимального элемента: {string.Join(" ", MinElement(array))}");
int [,] newArray = DeleteMin(array, minElement);
PrintArray(newArray);
