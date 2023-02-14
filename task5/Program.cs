// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void SpiralArray(int[,] array, int n)
{
  int i = 0;
  int j = 0;
  int value = 1;
  for (int e = 0; e < n * n; e++)
  {
    int k = 0;
    do { array[i, j++] = value++; } while (++k < n - 1);
    for (k = 0; k < n - 1; k++) array[i++, j] = value++;
    for (k = 0; k < n - 1; k++) array[i, j--] = value++;
    for (k = 0; k < n - 1; k++) array[i--, j] = value++;
    ++i; ++j;
    n = n < 2 ? 0 : n - 2;
  }
}


void ShowArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (arr[i, j] < 10)
      {
        Console.Write("0" + arr[i, j]);
        Console.Write(" ");
      }
      else Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
  }
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int n = GetNum("Введите количество строк и столбцов массива: ");
int[,] array = new int[n, n];
SpiralArray(array, n);
ShowArray(array);