// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int n = new Random().Next(2, 6);
int[,] matr = new int[n, n];

FillArray(matr);
PrintArray(matr);

Console.WriteLine("Среднее арифметическое каждого столбца");
for (int j = 0; j < n; j++)
{
    double a = 0;

    for (int i = 0; i < n; i++)
    {
        a += matr[i, j];
    }
    a /= n;

    Console.WriteLine($"Столбец {j + 1}: {Math.Round(a, 3)}; ");
}
Console.WriteLine();

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
