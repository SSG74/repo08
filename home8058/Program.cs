// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int CalcNumber(int [,] matrixA, int [,] matrixB, int rowA, int colB)
{
    int mult;
    int sum = 0;
    for (int j=0; j < matrixB.GetLength(1); j++)
    {
        mult=matrixA[rowA, j]*matrixB[j, colB];
        sum=sum+mult;
    }
return sum;
}
//  Выводим на печать массивы
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
// Заполняем первоначальные массивы
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
Console.WriteLine();
// Создаем матрицу и заполняем ее случайными числами
int[,] matrixA = FillArray(rows, columns, 1, 10);
int[,] matrixB = FillArray(rows, columns, 1, 10);
//  Выводим массивы на экран
PrintArray(matrixA);
Console.WriteLine();
PrintArray(matrixB);
Console.WriteLine();
int col = matrixB.GetLength(1);
int row = matrixB.GetLength(0);
int[,] ArrayNew = new int[rows, columns];
for (int i = 0; i<columns; i++)
{
    for (int j = 0; j<columns; j++)
    {
        ArrayNew[i,j] = CalcNumber(matrixA, matrixB, i, j);
    }
}
//вывод на печать матрицы умножения
PrintArray(ArrayNew);