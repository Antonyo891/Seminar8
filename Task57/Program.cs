/*Задача 57:**Составить частотный словарь элементов 
двумерного массива. Частотный словарь содержит информацию о том,
сколько раз встречается элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3,4, 6, 1, 2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза*/
using System;
using static System.Console;
int[,] GetArray(int line, int column) // создает двумерный массив с рандомными элементами
{
    int[,] result = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++) result[i, j] = new Random().Next(-9, 10);
    }
    return result;
}
int[] TwoDimensionalToOneDimensioal(int[,] array)
{
    int resultLength = array.GetLength(0) * array.GetLength(1);
    int[] result = new int[resultLength];
    int a = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[a] = array[i, j];
            a++;
        }
    return result;
}
void SortingArray(int[] array)
{

    for (int i = 0; i < array.Length / 2; i++)
    {
        int max = i, min = i;
        for (int j = i; j < array.Length - i; j++)
        {
            if (array[j] > array[max]) max = j;
            else if (array[j] < array[min]) min = j;
        }
        int saveFirst = array[i], saveLast = array[array.Length - i - 1];
        int saveMax = array[max], saveMin = array[min];
        array[array.Length - 1 - i] = saveMax;
        array[i] = saveMin;
        //WriteLine($" ghtl{string.Join(" ", array)} /");
        //WriteLine($"i={i} max = {max} min = {min} First = {saveFirst} Last = {saveLast}");
        if (max != i && min != i &&
        max != array.Length - 1 - i && min != array.Length - 1 - i)
        {
            array[max] = saveLast;
            array[min] = saveFirst;
        }
        else if (max==i&&min!=array.Length - 1 - i) array[min] = saveLast;
            else if (min==array.Length - 1 - i&&max!=i) array[max] = saveFirst;
            else if (min==i&&max!=array.Length - 1 - i) array[max]=saveLast;
            else if (max==array.Length - 1 - i&&min!=i) array[min]=saveFirst; 
        //Write($"{string.Join(" ", array)} /");
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
void FrequencyDictionary(int[] array)
{
    int count = 1;
    for (int i = 1; i < array.Length; i++)
        if (array[i] == array[i - 1]) count = count + 1;
        else
        {
            WriteLine($"{array[i - 1]} - {count} раз");
            count = 1;
        }
    WriteLine($"{array[array.Length - 1]} - {count} раз");
}
int[,] arrayTwoDimenional = GetArray(3, 3);
Clear();
PrintArray(arrayTwoDimenional);
int[] arrayOneDimensional = TwoDimensionalToOneDimensioal(arrayTwoDimenional);//{ 9, 2, 8, 5, 9, 9, 4, 5, 3 };
WriteLine($"[ {String.Join(" ", arrayOneDimensional)} ]");
SortingArray(arrayOneDimensional);
WriteLine($"[ {String.Join(" ", arrayOneDimensional)} ]");
FrequencyDictionary(arrayOneDimensional);