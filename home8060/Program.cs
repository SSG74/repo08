// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
void PrintArray(int[, ,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int c = 0; c <array.GetLength(2); c++)
            {
                Console.Write($"{array[i,j,c]}({i},{j},{c}) ");
            }
            Console.WriteLine("");
        }
    }
}
int[, ,] RandomNotRepeat(int [, ,] array)
{
    int minValue = 10;
    int maxValue = 99;
    Random rand = new Random();
    List<int> temp = new List<int>();
    for (int i = minValue; i < maxValue; i++)
    {
        temp.Add(i);
    }
    array = new int [array.GetLength(0),array.GetLength(0),array.GetLength(0)];
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            for (int b = 0; b<array.GetLength(2); b++)
            {
                array[i,j,b] = temp[rand.Next(0,temp.Count)];
                temp.Remove(array[i,j,b]);
            }
        }
    }
    return array;
}

int [, ,] array = {{{10,45}, {28,35}},{{79,90},{33,64}}};
PrintArray(array);
array = RandomNotRepeat(array);
