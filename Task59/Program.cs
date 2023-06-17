/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7*/
using System;
using static System.Console;
int[,] GetArrayRandomElement(int line, int column) // создает двумерный массив с рандомными элементами
{
    int[,] result = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++) result[i, j] = new Random().Next(9);
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Write($" {array[i, j]}");
        WriteLine();
    }
}
int[] IndexMinElement(int[,] array)
{
    int[] min = { 0, 0 };
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < array[min[0], min[1]])
            {
                min[0] = i;
                min[1] = j;
            }
    return min;
}
int[,] DeleteAcross(int[,] array, int line, int column)
{
    int lineLength = array.GetLength(1) - 1, columnLength = array.GetLength(0) - 1;
    int[,] result = new int[lineLength, columnLength];
    int[] min = { 0, 0 };
    int a = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        if (i != line)
        {   int b = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                
                if (j != column)
                {
                    result[a, b] = array[i, j];
                    b++;
                }
            }
            a++;}
    }
    return result;
}
Clear();
int [,] array = GetArrayRandomElement(5,5);
PrintArray(array);
int [] index = IndexMinElement(array);
int [,] array1 = DeleteAcross(array,index[0],index[1]);
PrintArray(array1);
