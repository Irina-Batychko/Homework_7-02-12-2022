/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет   */

int countRows = ReadInt("Введите колличество строк:  ");
int countColumns = ReadInt("Введите количество столбцов:  ");
int[,] array = new int[countRows, countColumns];

Console.Write("Введите позицию строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

FillMatrixRandomNumbers(array);
Console.WriteLine();

if (rows < countRows && columns < countColumns)
{
    Console.WriteLine("Значение элемента по данным позициям: -> " + array[rows, columns]);
}
else
    Console.WriteLine("Такого элемента в массиве нет!");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrixRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}