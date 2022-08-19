// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7   - я так понимаю, тут неправильно написали пример (вместо убывания здесь возрастание)
// 2 3 5 9     буду делать как в задании (по убыванию)
// 2 4 4 8

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

void Decrease(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for ( int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i,k] < arr[i,k+1])
                {
                    int temp = arr[i,k+1];
                    arr[i,k+1] = arr[i,k];
                    arr[i,k] = temp;
                }
            }
        }
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];

FillArray(array);
PrintArray(array);
Decrease(array);
Console.WriteLine();
Console.WriteLine("Новый массив:");
PrintArray(array);