
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.Clear();

// Ввод данных-------------------------------------------------------

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

double[,] array = GetArray(rows, columns, 0, 10);
PrintDoubleArray(array);

double[] resultArray = SerchAverageOfColumns(array);
PrintResultArray(resultArray);

// Создание массива типа DOUBLE---------------------------------------

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] inArray = new double[m, n];
    Random rnd = new Random();

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            inArray[i, j] = Math.Round(rnd.NextDouble() * (maxValue - minValue) + minValue, 1);
        }
    }
    return inArray;
}

// Вывод массива типа DOUBLE--------------------------------------------

void PrintDoubleArray(double[,] inArray)
{   
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"[ ");
            Console.Write($" {inArray[i, j]} ");
            Console.Write($" ]");
        }
        Console.ResetColor();
        Console.WriteLine();
    }
}

// Поиск среднего арифметического в массиве-----------------------------

double[] SerchAverageOfColumns (double[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            result[j] += inArray[i, j];
        }
        result[j] = Math.Round(result[j] / inArray.GetLength(0),1);
    }
    return result;
}

void PrintResultArray(double[] inArray)
{   
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"[ ");
        Console.Write($" {inArray[i]} ");
        Console.Write($" ]");
        Console.ResetColor();
    }
}