// Задайте прямоугольный двумерный массив. напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка.

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine();
    }
}

int SumElements(int[,] arr, int i)
{
  int sumRow = arr[i,0];
  for (int j = 1; j < arr.GetLength(1); j++)
  {
    sumRow += arr[i,j];
  }
  return sumRow;
}

int m = new Random().Next(3,6);
int n = new Random().Next(3,6);
int[,] array = new int[m,n];

FillArray(array);
PrintArray(array);

int minSumRow = 0;
int sumRow = SumElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumRow = SumElements(array,i);
    if (sumRow > tempSumRow)
    {
        sumRow = tempSumRow;
        minSumRow = i;
    }
}

Console.Write($"Номер строки с наименьшей суммой элементов: {minSumRow + 1}");