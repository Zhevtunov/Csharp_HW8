// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] CompositionMatrix(int[,] one, int[,] two)
{
  int[,] result = new int[one.GetLength(0), one.GetLength(1)];
  for (int i = 0; i < one.GetLength(0); i++)
  {
    for (int j = 0; j < two.GetLength(1); j++)
    {
      for (int k = 0; k < one.GetLength(1); k++)
      {
        result[i, j] += one[i, k] * two[k, j];
      }
    }
  }
  return result;
}

void ShowArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

int[,] GenerateMatrix(int rows, int columns, int lowerBound, int upperBound)
{
  int[,] arr = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      arr[i, j] = new Random().Next(lowerBound, upperBound + 1);
  return arr;
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int n = GetNum("Введите количество строк матрицы: ");
int m = GetNum("Введите количество столбцов матрицы: ");
if (n != m)
{
  Console.WriteLine("Матрицы нельзя перемножить ");
}
else
{
  int[,] matrixOne = GenerateMatrix(n, m, 0, 9);
  int[,] matrixTwo = GenerateMatrix(n, m, 0, 9);
  ShowArray(matrixOne);
  Console.WriteLine();
  ShowArray(matrixTwo);
  int[,] matrixMultiplication = CompositionMatrix(matrixOne, matrixTwo);
  Console.WriteLine();
  ShowArray(matrixMultiplication);
}