// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
Console.WriteLine("Введите количество строк : ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов : ");
int colums = int.Parse(Console.ReadLine()!);


double[,] array = GetArray(rows, colums);
PrintArr(array);

double[,] GetArray(int m, int n)
{
    double[,] res = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            res[i, j] = Math.Round (new Random().NextDouble(),1);
        }
    }
    return res;
}

void PrintArr(double[,] array)
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