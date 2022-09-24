/* Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет */

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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
(int, bool) CheckPosition(int[,] array, int row, int column)
{
    int value = 0;
    string message = string.Empty;
    
    if (0 <= row && row < array.GetLength(0) &&
        0 <= column && column < array.GetLength(1))
    {
        return (value = array[row, column], true);
    }

    return (value, false);
}
int Promt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());

    return result;
}

int[,] NewArray = GenerateArray(3, 3, -100, 100);
PrintArray(NewArray);
int row = Promt("Введите номер строки: ");
int column = Promt("Введите номер столбца: ");
(int value, bool result) = CheckPosition(NewArray, row, column);
if (result)
{
    Console.WriteLine($"Значение эл-та на позиции [{row}, {column}] равно: {value}");
}
else
{
    Console.WriteLine($"В массиве отсутсвует элемент с позицией [{row}, {column}], так как размерность массива: {NewArray.GetLength(0)} x {NewArray.GetLength(1)}\n (позиции начинаются с 0)");
}
