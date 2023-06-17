/*Задача 61: Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника*/
using System;
using static System.Console;
using System.Windows;
//const int cellWidht = 2;
int Factorial(int number)
{
    int result = 1;
    if (number == 0) return 1;
    for (int i = 1; i <= number; i++) result *= i;
    return result;
}
void TreanglePascalPrint(int line)
{
    int length = 4;
    int topPosition = line * length+line;
    SetCursorPosition(topPosition - length, 1);
    int element = 1;
    for (int i = 0; i < line; i++)
        for (int j = 0; j <= i; j++)
        {
            element = Factorial(i) / (Factorial(j) * Factorial(i - j));
            int position = topPosition - length * (i + 1) + length * j * 2;
            SetCursorPosition(position, i + 1);
            WriteLine(element);
        }
}
Clear();
TreanglePascalPrint(13);
