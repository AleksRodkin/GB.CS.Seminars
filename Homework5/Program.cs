// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] ThreeDigitArray(int size)
{
  int[] array = new int[size];

  for(int i = 0; i < size; i++)
    array[i] = new Random().Next(100, 1000);

  return array;
}

void PrintArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length - 1; i++)
    Console.Write(array[i] + ", ");
  Console.Write(array[array.Length - 1]);
  Console.WriteLine("]");
}

int FindEvenNumbers(int[] array)
{
  int count = 0;

  for(int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
      count++;
  }

  return count;
}

Console.WriteLine("******************************************************");
Console.WriteLine("Задача 34: Данная программа задает массив заполненный случайными положительными трёхзначными числами, а затем показывает количество чётных чисел в массиве.");
Console.Write("Введите количество элементов массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(1000);
int[] newArray = ThreeDigitArray(arraySize);
Console.WriteLine();
Console.Write("Массив трёхзначных чисел: ");
PrintArray(newArray);
Thread.Sleep(1000);
Console.WriteLine();
Console.Write("Количество чётных чисел в массиве: ");
Thread.Sleep(2000);
int evenNumberCount = FindEvenNumbers(newArray);
Console.WriteLine(evenNumberCount);
Thread.Sleep(1000);
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(2000);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] RandomizeArray(int size, int minValue, int maxValue)
{
  int[] array = new int[size];

  for(int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue + 1);

  return array;
}

int SumOfOdd(int[] array)
{
  int sum = 0;

  for(int i = 1; i < array.Length; i += 2)
    sum += array[i];

  return sum;
}

Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine("Задача 36: Данная программа задает одномерный массив, заполненный случайными числами, затем находит сумму элементов, стоящих на нечётных позициях.");
Console.Write("Введите количество элементов массива: ");
int newArraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов массива: ");
int newArrayMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int newArrayMax = Convert.ToInt32(Console.ReadLine());
int[] newArray2 = RandomizeArray(newArraySize, newArrayMin, newArrayMax);
Thread.Sleep(1000);
Console.WriteLine();
Console.Write("Массив трёхзначных чисел: ");
PrintArray(newArray2);
Console.WriteLine();
Console.Write("Cумма элементов, стоящих на нечётных позициях - ");
Thread.Sleep(2000);
int sumOfOdd = SumOfOdd(newArray2);
Console.WriteLine(sumOfOdd);
Thread.Sleep(2000);
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(3000);



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] DoubleRandomArray(int size, double minValue, double maxValue)
{
  double[] array = new double[size];

  for(int i = 0; i < size; i++)
  {
    array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    array[i] = Math.Round(array[i], 2);
  }

  return array;
}

double FindMinMaxDiff(double[] array)
{
  double min = array[0];
  double max = array[1];

  if (array[0] > array[1])
  {
    min = array[1];
    max = array[0];
  }
    
  for(int i = 2; i < array.Length; i++)
  {
    if (array[i] > max)
      max = array[i];
    else if (array[i] < min)
      min = array[i];
  }

  double difference = max - min;
  difference = Math.Round(difference, 2);

  Console.WriteLine($"Максимальное значение: {max}, минимальное значение: {min}, разница: {difference}");
  return difference;
}

void PrintDoubleArray(double[] array)
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
Console.WriteLine("Задача 38: Программа задает массив вещественных чисел, а затем находит разницу максимального и минимального элементов массива.");
Console.Write("Введите количество элементов массива: ");
int nextArraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов массива: ");
int nextArrayMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int nextArrayMax = Convert.ToInt32(Console.ReadLine());
double[] nextArray = DoubleRandomArray(nextArraySize, nextArrayMin, nextArrayMax);
Thread.Sleep(1000);
Console.WriteLine();
Console.Write("Массив вещественных чисел: ");
PrintDoubleArray(nextArray);
Console.WriteLine();
Thread.Sleep(2000);
double diffMaxMin = FindMinMaxDiff(nextArray);
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("*** Вот и всё, ребята! ***");

