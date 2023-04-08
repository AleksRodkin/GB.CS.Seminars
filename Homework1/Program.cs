// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("*******************************************************");
Console.WriteLine("Задача 2");
Console.WriteLine("Данная программа принимает два целых числа и выдаёт большее из них");
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");
Console.WriteLine("Ответ:");

if (num1 > num2)
  Console.WriteLine($"Число {num1} больше {num2}");
else if (num1 == num2)
  Console.WriteLine("Числа равны");
else
  Console.WriteLine($"Число {num2} больше {num1}");

Console.WriteLine(" ");
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(3000);  

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine(" ");
Console.WriteLine("*******************************************************");
Console.WriteLine("Задача 4");
Console.WriteLine("Данная программа принимает три целых числа и выдаёт большее из них");
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");
Console.WriteLine("Ответ:");

if (number1 == number2 && number2 == number3)
  Console.WriteLine("Все три числа равны");
else if (number1 == number2)
{
  if (number1 > number3)
    Console.WriteLine($"Два числа равны {number1}, число {number1} больше {number3}");
  else
    Console.WriteLine($"Два числа равны {number1}, число {number3} больше {number1}");
}
else if (number2 == number3)
{
  if (number2 > number1)
    Console.WriteLine($"Два числа равны {number2}, число {number2} больше {number1}");
  else
    Console.WriteLine($"Два числа равны {number2}, число {number1} больше {number2}");
}
else if (number3 == number1)
{
  if (number3 > number2)
    Console.WriteLine($"Два числа равны {number3}, число {number3} больше {number2}");
  else
    Console.WriteLine($"Два числа равны {number3}, число {number2} больше {number3}");
}
else
{
  if (number1 > number2 && number1 > number3)
    Console.WriteLine($"Число {number1} больше {number2} и {number3}");
  else if (number2 > number1 && number2 > number3)
    Console.WriteLine($"Число {number2} больше {number1} и {number3}");
  else if (number3 > number1 && number3 > number2)
    Console.WriteLine($"Число {number3} больше {number1} и {number2}");
  else 
    Console.WriteLine("Что-то не так");
}

Console.WriteLine(" ");
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(3000);  

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine(" ");
Console.WriteLine("*******************************************************");
Console.WriteLine("Задача 6");
Console.WriteLine("Данная программа принимает целое число и выдаёт, является ли оно чётным");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");
Console.WriteLine("Ответ:");

if (number % 2 == 0)
  Console.WriteLine($"Число {number} чётное");
else 
  Console.WriteLine($"Число {number} нечётное");

Console.WriteLine(" ");
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(3000);  

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine(" ");
Console.WriteLine("*******************************************************");
Console.WriteLine("Задача 8");
Console.WriteLine("Данная программа на вход принимает целое число (N), а на выходе показывает все чётные числа от 1 до N");
Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int current = 1;

Console.WriteLine(" ");
Console.WriteLine("Ответ:");

if (numberN <= 0)
  Console.WriteLine("Введеное число меньше или равно нулю");
else if (numberN == 1)
  Console.WriteLine("Введеное число равно 1, положительные четные числа начинаются с числа 2");
else
{
  Console.WriteLine("Чётные числа от 1 до " + numberN + ":");
  while (current <= numberN)
  {
    if (current % 2 == 0)
      Console.Write(current + " ");
    
    current += 1;
  }
}

Console.WriteLine(" ");
Console.WriteLine("*** Вот и всё, ребята! ***");