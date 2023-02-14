// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


int MinimumLine(int[,] arr)
{
  int sum = 0;
  int count = 0;
  int sumTemp = 0;
  for (int j = 0; j < arr.GetLength(1); j++) sum += arr[0, j];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++) sumTemp += arr[i, j];
    if (sumTemp < sum)
    {
      sum = sumTemp;
      count = i;
    }
    sumTemp = 0;
  }
  return count;
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
int[,] array = GenerateArray(n, m, 0, 9);
ShowArray(array);
int count = MinimumLine(array);
Console.WriteLine($"Наименьшая сумма элементов в строке №: {count + 1}");