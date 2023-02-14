// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int[,] SortDecrease(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1) - 1; j++)
    {
      int maxPosition = j;
      for (int k = j + 1; k < arr.GetLength(1); k++)
      {
        if (arr[i, maxPosition] < arr[i, k]) maxPosition = k;
      }
      (arr[i, j], arr[i, maxPosition]) = (arr[i, maxPosition], arr[i, j]);
    }
  }
  return arr;
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

int[,] GenerateArray(int rows, int columns, int lowerBound, int upperBound)
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

int n = GetNum("Введите количество строк массива: ");
int m = GetNum("Введите количество столбцов массива: ");
int[,] array = GenerateArray(n, m, 1, 9);
ShowArray(array);
int[,] sortArray = SortDecrease(array);
Console.WriteLine();
ShowArray(sortArray);