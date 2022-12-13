//Задача 58:
//Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.WriteLine("Введите кол-во строк 1-го массива:");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов 1-го массива");
int columnsA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк 2-го массива:");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов 2-го массива:");
int columnsB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон значений: от 0 до");
int range = Convert.ToInt32(Console.ReadLine());



int[,] CreateMatrixRndInt (int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}\t");
            else Console.WriteLine($"{matrix[i, j]}");
        }
    }
}

int[,] GetMultiplMatrix(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int h = 0; h < array1.GetLength(1); h++)
            {
                array3[i, j] += array1[i, h] * array2[h, j];
            }
        }
    }
    return array3;
}





if (columnsA == rowsB)
{
    int[,] arrayA = CreateMatrixRndInt(rowsA, columnsA, 0, range);
    int[,] arrayB = CreateMatrixRndInt(rowsB, columnsB, 0, range);
    int[,] arrayC = GetMultiplMatrix(arrayA, arrayB);
    Console.WriteLine("Первая матрица:");
    PrintMatrix(arrayA);
    Console.WriteLine();
    Console.WriteLine("Вторая матрица:");
    PrintMatrix(arrayB);
    Console.WriteLine();
    Console.WriteLine("Результирующая матрица:");
    PrintMatrix(arrayC);
}
else
{
    Console.WriteLine("Ошибка! Умножение невозможно!");
}