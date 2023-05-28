int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
  int[,] array = new int[rows, columns];

  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = new Random().Next(minValue, maxValue + 1);

  return array;
}

void Show2dArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

void Show2dArrayWithZero(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j].ToString("00") + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

void PrintArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length - 1; i++)
  {
    Console.Write(array[i] + ", ");
  }
  Console.Write(array[array.Length - 1]);
  Console.WriteLine("]");
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
    var count = array[startIndex];
    array[startIndex] = array[endIndex];
    array[endIndex] = count;
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
Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine("Задача 54: Программа задает двумерный массив, а затем упорядочивает элементы каждой строки по убыванию");
Console.WriteLine("Зададим двумерный массив");
Console.Write("Введите количество рядов в массиве: ");
int myArrayRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int myArrayColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов массива: ");
int myArrayMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int myArrayMax = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(myArrayRows, myArrayColumns, myArrayMin, myArrayMax);
Console.WriteLine("Заданный массив:");
Show2dArray(myArray);
Thread.Sleep(1000);
Console.WriteLine("Упорядоченный массив:");
SortAndPrint2dArrayRows(myArray);
Console.WriteLine();
Thread.Sleep(2000);
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(3000);





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[] FindSumInRows(int[,] array)
{
  int[] sumArray = new int[array.GetLength(0)];

  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sumArray[i] += array[i, j];
    }

  return sumArray;
}

int FindMinInArray(int[] array)
{
  int min = array[0];
  int minIndex = 0;
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] < min)
    {
      min = array[i];
      minIndex = i;
    }
  }
	Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minIndex + 1} строка");
  return minIndex;
}
Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine("Задача 56: Программа задает прямоугольный двумерный массив, а затем находит строку с наименьшей суммой элементов");
Console.Write("Введите количество рядов в массиве: ");
int nextArrayRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int nextArrayColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов массива: ");
int nextArrayMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int nextArrayMax = Convert.ToInt32(Console.ReadLine());
int[,] nextArray = CreateRandom2dArray(nextArrayRows, nextArrayColumns, nextArrayMin, nextArrayMax);
Console.WriteLine("Заданный массив:");
Show2dArray(nextArray);
Thread.Sleep(1000);
Console.WriteLine("Суммы каждого ряда");
int[] sumInRowsArray = FindSumInRows(nextArray);
PrintArray(sumInRowsArray);
FindMinInArray(sumInRowsArray);
Console.WriteLine();
Thread.Sleep(2000);
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(3000);





// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] multiplyTwoMatrixes(int[,] A, int[,] B)
{
  int M = A.GetLength(0);
  int N = B.GetLength(1);
  int K = A.GetLength(1);
  int[,] C = new int[M, N];
  for (int i = 0; i < M; i++)
  {
    for (int j = 0; j < N; j++)
    {
      for (int k = 0; k < K; k++)
        C[i, j] += A[i, k] * B[k, j];
    }
  }
  return C;
}
Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine("Задача 58: Программа задаёт две матрицы, затем находит произведение двух матриц");
Console.WriteLine("Чтобы одну матрицу можно было умножить на другую матрицу, число столбцов первой должно равняться числу строк второй матрицы.");
Console.Write("Введите количество строк в первой матрице: ");
int firstMRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в первой матрице (= количество строк во второй матрице): ");
int firstMColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов во второй матрице: ");
int secondMColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение матриц: ");
int matrixMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение матриц: ");
int matrixMax = Convert.ToInt32(Console.ReadLine());
int[,] firstMatrix = CreateRandom2dArray(firstMRows, firstMColumns, matrixMin, matrixMax);
Console.WriteLine();
Console.WriteLine("Первая заданная матрица:");
Show2dArray(firstMatrix);
Thread.Sleep(1000);
int[,] secondMatrix = CreateRandom2dArray(firstMColumns, secondMColumns, matrixMin, matrixMax);
Console.WriteLine("Вторая заданная матрица:");
Show2dArray(secondMatrix);
Thread.Sleep(2000);
Console.WriteLine("Произведение матриц:");
int[,] resultMatrix = multiplyTwoMatrixes(firstMatrix, secondMatrix);
Show2dArray(resultMatrix);
Thread.Sleep(2000);
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(5000);





// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] new3dArray = {{ {14, 45, 32}, { 54, 15, 42}, { 25, 63, 43 }},
                    	{ {19, 84, 66}, { 95, 46, 21}, { 31, 12, 88 }},
                    	{ {17, 27, 33}, { 64, 62, 44}, { 76, 47, 29 }}};

void Show3dArray(int[,,] array)
{
  for (int k = 0; k < array.GetLength(2); k++)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write(array[i, j, k] + $"({i},{j},{k}) ");
      }
			Console.WriteLine();
    }
		Console.WriteLine();
  }
}

Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента");
Console.WriteLine("Я решил сделать массив размером 3 x 3 x 3");
Thread.Sleep(3500);
Console.WriteLine();
Console.WriteLine("БУМ! А ВОТ И ОН");
Console.WriteLine();
Thread.Sleep(1000);
Show3dArray(new3dArray);
Thread.Sleep(2000);
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(3000);





// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] SpiralArray(int size)
{
  int[,] array = new int[size, size];

  int i = 0;
  int j = 0;
  int count = 1;

  while (count <= array.GetLength(0) * array.GetLength(1))
  {
    array[i, j] = count;
    count++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    {
      j++;
    }
    else if (i < j && i + j >= array.GetLength(0) - 1)
    {
      i++;
    }
    else if (i >= j && i + j > array.GetLength(1) - 1)
    {
      j--;
    }
    else if (i > j + 1 && i + j <= array.GetLength(0) - 1)
    {
      i--;
    }
  }
  return array;
}

Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine("Задача 62. Данная программа заполняет спирально массив N на N");
Console.Write("Введите количество строк/столбцов в квардратном массиве: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] spiralArray = SpiralArray(arraySize);
Show2dArrayWithZero(spiralArray);
Thread.Sleep(2000);
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("*** Ну вот и всё, ребята! ***");
Console.WriteLine();