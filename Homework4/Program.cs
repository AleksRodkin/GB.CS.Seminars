// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponentiation(int number, int rate)
{
  int result = 1;
  for(int i = 1; i <= rate; i++)
  {
    result = result * number;
  }

  return result;
}

Console.WriteLine("3 в 5 степени = " + Exponentiation(3,5));



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int CountingInnerDigits(int num)
{
  int result = 0;
  
  while(num > 0)
  {
    result += num % 10;
    num /= 10;
  } 
  return result;
}

Console.WriteLine("Сумма чисел числа 1352 = " + CountingInnerDigits(1352));



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] NewArray(int Length)
{
  int[] array = new int[Length];

  for(int i = 0; i < Length; i++)
  {
    array[i] = new Random().Next(1, 100);
  }
  return array;
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

int[] newArray = NewArray(8);
Console.Write("Сгенерированный массив в диапазоне от 1 до 99: ");
PrintArray(newArray);