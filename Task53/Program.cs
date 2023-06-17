/*Задача 53: Задайте двумерный массив. Напишите программу, которая
 поменяет местами первую и последнюю строку массива.*/
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
void ChangeLine(int[,] array, int ChangeLine1, int ChangeLine2)
{
    int Line = array.GetLength(0), column = array.GetLength(1);
    int saveElement;
    for (int j = 0; j < column; j++)
    {
        saveElement = array[ChangeLine1, j];
        array[ChangeLine1, j] = array[ChangeLine2, j];
        array[ChangeLine2, j] = saveElement;
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Write($" {array[i, j]}");
        WriteLine();
    }
}
Clear();
int[,] array = GetArrayRandomElement(5, 5);
PrintArray(array);
WriteLine();
ChangeLine(array, 0, array.GetLength(1)-1);
PrintArray(array);
