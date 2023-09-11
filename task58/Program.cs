/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.WriteLine("Введите размер матрицы x, y:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

int[,] FillArray (int x, int y)
{
    int[,] array = new int[x, y];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2) // Работает только с матрицами одинаковых размеров
{
    int[,] multiplyArray = new int[matrix2.GetLength(1), matrix1.GetLength(0)];
    for (int i = 0; i < matrix1.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix1.GetLength(0); ++j)
        {
            for (int k = 0; k < matrix2.GetLength(1); ++k)
            {
                multiplyArray[i, k] += matrix1[i, j] * matrix2[j, k];
            }
        }
    }
    return multiplyArray;
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

int[,] array1 = FillArray(x, y);
int[,] array2 = FillArray(x, y);
int[,] multiplyArray = MultiplyMatrix(array1, array2);
PrintArray(multiplyArray);
