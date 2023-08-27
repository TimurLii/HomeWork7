// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// позиция i = 4, j = 2 -> такой позиции нет
// позиция i = 1, j = 0 -> 5'

Console.WriteLine("Введите колличесвто строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличесвто столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите индекс строки : ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите индекс столбца: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.Clear();
int[,] array = GetArr(rows, colums, 1, 10);
PrintArr(array);
find(array);



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


void find(int[,] array)
{
    int Inum = num1;
    int Jnum = num2;
    if (Inum < array.GetLength(0) && Jnum < array.GetLength(1))
    {
        Console.WriteLine($"Элемент с индексом {Inum} и {Jnum} : " + array[Inum, Jnum]);
    }
    else Console.WriteLine($"Данный элемент в массиве отсутствует");

}