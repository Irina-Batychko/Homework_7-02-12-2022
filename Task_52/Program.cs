/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:1 4 7 25 9 2 38 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.  */

int countRows = ReadInt("Введите колличество строк:  ");
int countColumns = ReadInt("Введите количество столбцов:  ");
int[,] array = new int[countRows, countColumns];

Console.WriteLine();
FillMatrixRandomNumbers(array);

void MathActionMatrix(int[,] array)
{
    double arithmeticMean = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            arithmeticMean += array[i, j];
        }
        Console.Write(Math.Round(arithmeticMean / countRows, 1) + "; ");
        arithmeticMean = 0;
    }
}
MathActionMatrix(array);


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
            array[i, j] = new Random().Next(1, 9);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}