// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2dArray(int rows, int columns, double minValue, double maxValue)
{
	double[,] array = new double[rows, columns];
	
	for(int i = 0; i < rows; i++)
		for(int j = 0; j < columns; j++)
    {
			array[i,j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
      array[i,j] = Math.Round(array[i,j], 1);
    }

  return array;
}

void Show2dDoubleArray(double[,] array)
{
	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
			Console.Write(array[i,j] + " ");
		Console.WriteLine();
	}
	Console.WriteLine();
}

Console.WriteLine("******************************************************");
Console.WriteLine("Задача 47. Данная програма задает двумерный массив размером m×n, заполненный случайными вещественными числами.");
Console.Write("Введите количество рядов в массиве (m): ");
int myArrayRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве (n): ");
int myArrayColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов массива: ");
int myArrayMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int myArrayMax = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreateRandom2dArray(myArrayRows, myArrayColumns, myArrayMin, myArrayMax);
Thread.Sleep(1000);
Console.WriteLine();
Console.WriteLine($"Двумерный массив вещественных чисел размером {myArrayRows}x{myArrayColumns}: ");
Show2dDoubleArray(myArray);
Thread.Sleep(2000);
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(3000);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void CheckElementInArray(double[,] array, int row, int column)
{
  if (row <= array.GetLength(0) && column <= array.GetLength(1))
    Console.WriteLine($"Элемент массива на {row} ряду и в {column} колонне - {array[row-1,column-1]}");
  else
    Console.WriteLine("Числа с такими индексами в массиве нет");
}

Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine("Задача 50. Данная программа принимает позиции элемента в двумерном массиве и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine();
Console.Write("Для начала укажем параметры двумерного массива.");
Console.WriteLine();
Console.Write("Введите количество рядов в массиве: ");
int newArrayRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int newArrayColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов массива: ");
int newArrayMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int newArrayMax = Convert.ToInt32(Console.ReadLine());
double[,] newArray = CreateRandom2dArray(newArrayRows, newArrayColumns, newArrayMin, newArrayMax);
Thread.Sleep(1000);
Console.WriteLine();
Console.WriteLine($"Двумерный массив вещественных чисел размером {newArrayRows}x{newArrayColumns}: ");
Show2dDoubleArray(newArray);
Thread.Sleep(2000);
Console.WriteLine("Теперь укажите позицию элемента в данном массиве, из которого хотите вывести значение");
Console.WriteLine();
Console.WriteLine("ВНИМАНИЕ! Нумерация позиций начинается (по-человечески) с единицы!");
Console.WriteLine();
Console.Write("Введите номер ряда в массиве: ");
int newArrayCheckRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца в массиве: ");
int newArrayCheckColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Thread.Sleep(1000);
CheckElementInArray(newArray, newArrayCheckRow, newArrayCheckColumn);
Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(3000);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateNewRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
	int[,] array = new int[rows, columns];
	
	for(int i = 0; i < rows; i++)
		for(int j = 0; j < columns; j++)
			array[i,j] = new Random().Next(minValue, maxValue + 1);
	
	return array;
}

double[] FindColumnAverage(int[,] array)
{
  double[] sum = new double[array.GetLength(1)];

  for(int i = 0; i < array.GetLength(0); i++)
    for(int j = 0; j < array.GetLength(1); j++)
        sum[j] = sum[j] + array[i,j];
  
  for (int i = 0; i < sum.Length; i++)
  {
    sum[i] /= array.GetLength(0);
    sum[i] = Math.Round(sum[i], 2);
  }

  return sum;
}

void Print2dArray(int[,] array)
{
	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
			Console.Write(array[i,j] + " ");
		Console.WriteLine();
	}
	Console.WriteLine();
}

void PrintArray(double[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length - 1; i++)
  {
    Console.Write(array[i] + ", ");
  }
  Console.Write(array[array.Length - 1]);
  Console.WriteLine("]");
}

Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine("Задача 52. Данная программа задает двумерный массив из целых чисел, а затем находит среднее арифметическое элементов в каждом столбце.");
Console.WriteLine();
Console.WriteLine("Снова укажем параметры массива.");
Console.Write("Введите количество рядов в массиве: ");
int nextArrayRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int nextArrayColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов массива: ");
int nextArrayMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int nextArrayMax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] nextArray = CreateNewRandom2dArray(nextArrayRows, nextArrayColumns, nextArrayMin, nextArrayMax);
Print2dArray(nextArray);
Thread.Sleep(2000);
Console.WriteLine("Массив средних арифметических каждого столбца: ");
double[] avgArray = FindColumnAverage(nextArray);
PrintArray(avgArray);
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("*** Ну вот и всё, ребята! ***");
Console.WriteLine();