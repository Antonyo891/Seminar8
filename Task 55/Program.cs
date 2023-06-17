/*Задача 55: Задайте двумерный массив. Напишите программу, которая 
заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.*/
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
int [,] ChangeLineToColumn (int [,] array)
{
    int lineLength = array.GetLength(1), columnLength = array.GetLength(0);
    int [,] result = new int [lineLength,columnLength];
    if (lineLength == columnLength) 
    {
        for (int i = 0; i<lineLength; i++ )
        for (int j =0; j<columnLength; j++) result[j,i] = array [i,j]; 
    }
    return result;
}
Clear();
int [,] array = GetArrayRandomElement(5,5);
PrintArray(array);
if (array.GetLength(0)!=array.GetLength(1)) WriteLine("Данный массив не перевернуть");
else {int [,] array1 = ChangeLineToColumn(array);
WriteLine();
PrintArray(array1);}
