// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

Console.Write("Введите позицию столбца: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите позицию строки: ");
int colomns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(3, 4, 0, 10);

ElementSearch(array, rows, colomns);
PrintArray(array);
Console.WriteLine();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] inArray = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            inArray[i, j] = i + j;
        }
    }
    return inArray;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ElementSearch(int[,] inArray, int rows, int colomns)
{
    if (rows < inArray.GetLength(0) && colomns < inArray.GetLength(1))
        Console.WriteLine($"Искомый элемент ---> {inArray[rows, colomns]}");
    else
        Console.WriteLine($"Строка {rows} Колонка {colomns} ---> в массиве отсутствуют");

}

