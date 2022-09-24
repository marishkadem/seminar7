/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRnd, maxRnd + 1);
        }
    }

    return array;
}
void PrintArray(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    Console.WriteLine($"\nВаша матрица размерности {rows}x{cols}:\n");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] MeanColumns(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    double[] mean = new double[columns];
    for (int j = 0; j < cols; j++)
    {
        double summ = 0;
        for (int i = 0; i < rows; i++)
        {
            summ += array[i, j];
        }

        mean[j] = summ / rows;
    }

    return mean;
}

int[,] myarray = GenerateArray(3, 4, 0, 10);
PrintArray(myarray);
double[] meansInCols = MeanColumns(myarray);

string output = "Средние значения по столбцам: ";
foreach (double el in meansInCols)
{
    output += $"{el:f2}, ";
}
Console.WriteLine(output.Remove(output.Length - 2, 2));
