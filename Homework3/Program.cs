// Задача 19  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool cheсkPalindrome(int number)
{
  int reverseNumber = 0;
  int inputNumber = number;
  while (number > 0)
  {
    reverseNumber = (reverseNumber+(number % 10)) * 10;
    number /= 10;
  }
  reverseNumber /= 10;

  if (inputNumber == reverseNumber)
  {
    Console.WriteLine();
    Console.WriteLine("Данное число - палиндром");
    Console.WriteLine();
    return true;
  }
  else
  {
    Console.WriteLine();
    Console.WriteLine("Данное число не является палиндромом");
    Console.WriteLine();
    return false;
  }
}

Console.WriteLine("******************************************************");
Console.WriteLine("Задача 19. Данная программа принимает целое число и проверяет, является ли оно палиндромом");
Console.Write("Введите целое число: ");
cheсkPalindrome(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(3000);



// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
  double distance = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));

  distance = Math.Round(distance, 2);
  return distance;
}

Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine("Задача 21. Данная программа принимает координаты двух точек и находит расстояние между ними в 3D пространстве");
Console.WriteLine("Введите координаты: ");
Console.Write("Точка А, координата x: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка А, координата y: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка A, координата z: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка B, координата x: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка B, координата y: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка B, координата z: ");
int bz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Расстояние между точками: ");
Console.Write(FindDistance(ax, ay, az, bx, by, bz));
Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(3000);



// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubicTable(int num)
{
  int position = 1;
  while (num >= position)
  {
    Console.WriteLine($"{position} - {position*position*position}");
    position++;
  }
  return;
}

Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine("Задача 23. Данная программа принимает целое число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.Write("Введите целое число N: ");
CubicTable(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("*** Вот и всё, ребята! ***");