//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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
        for (int j = 0; j <arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int m = new Random().Next(3,6);
int n = new Random().Next(3,6);
int p = new Random().Next(3,6);

int[,] firstMatrix = new int[m,n];
int[,] secondMatrix = new int[n,p];
int[,] resultMatrix = new int[m,p];

FillArray(firstMatrix);
Console.WriteLine("Первая матрица: ");
Console.WriteLine();
PrintArray(firstMatrix);
Console.WriteLine();
FillArray(secondMatrix);
Console.WriteLine("Вторая матрица:");
Console.WriteLine();
PrintArray(secondMatrix);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
Console.WriteLine();
MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
PrintArray(resultMatrix);