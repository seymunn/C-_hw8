//Задача 54: 
//Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int h = 0; h < array.GetLength(1) - 1; h++)
      {
        if (array[i, h] < array[i, h + 1])
        {
          int temp = array[i, h + 1];
          array[i, h + 1] = array[i, h];
          array[i, h] = temp;
        }
      }
    }
  }
}

int[,] array2D = CreateMatrixRndInt(m, n, 0, range);
PrintMatrix(array2D);

Console.WriteLine("В итоге получается вот такой массив: ");
OrderArrayLines(array2D);
PrintMatrix(array2D);