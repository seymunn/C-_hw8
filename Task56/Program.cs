// Задача 56: 
//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и
//выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите кол-во строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
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

void GetSumOfColumns(int[,] matrix)
{
    int sum = int.MaxValue;
    int index = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            temp += matrix[i, j];
        }
        if (temp < sum)
        {
            sum = temp;
            index = j;
        }
        
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {index}");;
}

if (m != n)
{
    int[,] array2D = CreateMatrixRndInt(m, n, 0, range);
    PrintMatrix(array2D);
    GetSumOfColumns(array2D);
}
else
{
    Console.WriteLine("Ошибка! Массив не прямоугольный");
}