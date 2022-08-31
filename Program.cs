// Задача 59. Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен 
// наименьший элемент массива.

int[,] CreateArray2DimRandom(int row, int column, int maxEl)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(1, maxEl);
        }
    }
    return array;
}
void PrintArray2Dim(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}
int[] FindMinElArray(int[,] array)
{
    int minEl = array[0, 0];
    int[] xyMinEl = { 0, 0 };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minEl > array[i, j])
            {
                minEl = array[i, j]; xyMinEl[0] = i; xyMinEl[1] = j;
            }
        }
    }
    return xyMinEl;
}
Console.Clear();
int valueMaxElArray = new Random().Next(2, 10);
int rowArray = new Random().Next(2, valueMaxElArray);
int columnArray = new Random().Next(2, valueMaxElArray);
int[,] someArray = CreateArray2DimRandom(rowArray, columnArray, valueMaxElArray);

Console.WriteLine($"Массив {rowArray}x{columnArray}, значения от 1 до {valueMaxElArray}:");
PrintArray2Dim(someArray);
int[] xyMinElSomeArray = FindMinElArray(someArray);
Console.WriteLine(xyMinElSomeArray[0] + " " + xyMinElSomeArray[1]);
