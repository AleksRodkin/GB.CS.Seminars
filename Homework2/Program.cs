// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int СutNumber(int num)
{
  if (num >= 100 && num < 1000)
	{
    int result = (num / 10) % 10;
    Console.WriteLine();
    Console.WriteLine($"Вторая цифра числа {num} - {result}");
    Console.WriteLine();
	  return result; 
  } 
  else
  {
    Console.WriteLine();
    Console.WriteLine("Это не трёхзначное число");
    Console.WriteLine();
    return 0;
  }
}

Console.WriteLine("******************************************************");
Console.WriteLine("Задача 10: Данная программа принимает трёхзначное число и показывает вторую цифру этого числа");
Console.Write("Введите трёхзначное число: ");
int userInputNumber = Convert.ToInt32(Console.ReadLine());
int secondDigit = СutNumber(userInputNumber);
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(3000);  


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string ShowThirdDigit(int num)
{ 
  if (num >= 100)
  {
    while (num >= 1000)
    {
      num /= 10;
    }
    int result = num % 10;
    return "Третья цифра заданного числа: " + result;
  }
  return "Третьей цифры нет";
}  
Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine("Задача 13: Данная программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет");
Console.Write("Введите число: ");
int userInput = Convert.ToInt32(Console.ReadLine());
string funcResult = ShowThirdDigit(userInput);
Console.WriteLine();
Console.WriteLine(funcResult);
Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(3000);  


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool IsItHoliday(int day)
{
  if (day >= 1 && day <= 5)
  {
    Console.WriteLine("Опять работать, брат");
    return false;
  }
    
  else if (day == 6 || day == 7)
  {
    Console.WriteLine("Отдыхай, брат, выходной");
    return true;
  }
    
  else 
  {
    Console.WriteLine("Такого дня недели нет, брат");
    return false;
  }
}

Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine("Задача 15. Данная программа принимает на цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.Write("Введите цифру, обозначающую день недели: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
bool funcHolidayResult = IsItHoliday(userNumber);
Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("*** Вот и всё, ребята! ***");
Console.WriteLine();

