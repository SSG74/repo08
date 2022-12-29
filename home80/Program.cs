// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// выводим новый массив
void ExitArray(int[,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArrayInRows(int[,] array) // Пузырьковая сортировка по строкам
{
    int temp;
    for (int rowNum = 0; rowNum < array.GetLength(0); rowNum++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                if (array[rowNum, j] < array[rowNum, j+1])
                {
                    temp = array[rowNum, j];
                    array[rowNum, j] = array[rowNum, j+1];
                    array[rowNum, j+1] = temp;
                }
            }  
        }
    }
    return array;
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
// вывод пустой строки для разделения массивов
Console.WriteLine();
// Сортировка чисел в строках
// создание нового массива
matrix = ChangeArrayInRows(matrix);
// вывод на печать нового массива
ExitArray(matrix);