// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int FindMinSumRows(int[,] matrix, int rows, int columns)
{
    int sumMin=0;
    int rowMin=0;
    int sumRow=0;
    
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {          
            sumRow = sumRow + matrix[i,j];
        }
        if (i==0)  sumMin=sumRow;
        if (sumMin >= sumRow)
        {
            sumMin=sumRow;
            rowMin=i+1; 
        }
        sumRow=0;
    }
    return rowMin;
}
 //  Выводим на печать массив
void PrintArray(int[,] arr)
{
    for (int i=0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
// Заполняем массив
int[,] FillArray(int rows, int columns, int begin, int end)
{
    int[,] array = new int[rows, columns];
    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < columns; j++)
        {
            array[i, j] = new Random().Next(begin, end+1);
        }
    }
    return array;
}

// заводим и печатаем количество строк и столбцов
int EnterData(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// Запрос количества строк
int rows = EnterData("Введите количество строк: ");
// Запрос количества столбцов
int columns = EnterData("Введите количество столбцов: ");
// Создаем двухмерный массив и заполняем его случайными числами
int[,] matrix = FillArray(rows, columns, 1, 10);
//  Выводим массив на экран
PrintArray(matrix);
// ищем строку с наименьшей суммой чисел
int numRow = FindMinSumRows(matrix, rows, columns);
Console.WriteLine($"Номер строки c наименьшей суммой -> {numRow}");
// выводим номер строки