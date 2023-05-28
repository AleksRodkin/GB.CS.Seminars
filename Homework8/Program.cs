int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
	int[,] array = new int[rows, columns];
	
	for(int i = 0; i < rows; i++)
		for(int j = 0; j < columns; j++)
			array[i,j] = new Random().Next(minValue, maxValue + 1);
	
	return array;
}

void Show2dArray(int[,] array)
{
	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
			Console.Write(array[i,j] + " ");
		Console.WriteLine();
	}
	Console.WriteLine();
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void PrintArrayNoSquareBrackets(int[] array)
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.Write(array[array.Length - 1]);
  Console.WriteLine();
}

int[] StoogeSort(int[] array, int startIndex, int endIndex)
{
  if (array[startIndex] < array[endIndex])
  {
    var temp = array[startIndex];
    array[startIndex] = array[endIndex];
    array[endIndex] = temp;
  }

  if (endIndex - startIndex > 1)
  {
    var length = (endIndex - startIndex + 1) / 3;
    StoogeSort(array, startIndex, endIndex - length);
    StoogeSort(array, startIndex + length, endIndex);
    StoogeSort(array, startIndex, endIndex - length);
  }

  return array;
}

void SortAndPrint2dArrayRows(int[,] array)
{
  int[] rowArray = new int[array.GetLength(1)];

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      rowArray[j] = array[i, j];
    }
    StoogeSort(rowArray, 0, array.GetLength(1) - 1);
    PrintArrayNoSquareBrackets(rowArray);
  }
}

int[,] myArray = CreateRandom2dArray(3, 5, 10, 99);
Show2dArray(myArray);
SortAndPrint2dArrayRows(myArray);





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07