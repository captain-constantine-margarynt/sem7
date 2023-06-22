/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/


using System;
using static System.Console;

Clear();
Write("Generating array: ");
WriteLine();
Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
Write("Original array: ");
WriteLine();
PrintArray(array);
WriteLine();

Console.Write("Put row number: ");
int row = int.Parse(ReadLine());
Console.Write("Put column number: ");
int column = int.Parse(ReadLine());

findElement(row, column, array);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

void findElement (int row, int column, int [,] array) {
  for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (row < 0 | row > array.GetLength(0) | column < 0 | column > array.GetLength(1) ) {
            WriteLine("Element does not exist!");
            } 
            else
            {
                WriteLine("Element  = {0}", array[row, column]);
                break;
            }
        }
    }
    
}