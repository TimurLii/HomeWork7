﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Введите колличесвто строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличесвто столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] arr = GetArr(rows, colums, 1, 10);
PrintArr(arr);
average(arr);



int[,] GetArr(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void average(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        double avg = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum +=  array[j, i];
            avg = Math.Round(sum / array.GetLength(0), 1);
        }
        Console.WriteLine($"Среднее арифмитическое элементов столбца {i} : {avg}");
    }
}