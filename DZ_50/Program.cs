// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите номер строки: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine();

int n = new Random().Next(2, 7);
int[,] matr = new int[n, n];

FillArray(matr);
PrintArray(matr);

void FillArray(int[,] arr)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(-10, 20);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

if (row > matr.GetLength(0) || column > matr.GetLength(1)) Console.WriteLine($"Позиция: Строка {row}, Столбец {column} || Такого элемента в массиве нет");
else Console.WriteLine($"Позиция: Строка {row}, Столбец {column} || Число: {matr[row - 1, column - 1]}");

