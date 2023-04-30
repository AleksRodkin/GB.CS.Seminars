// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountPositive(int size)
{
  int count = 0;
  for (int i = 1; i <= size; i++)
  {
    Console.Write($"Введите {i}е число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 0)
      count++;
  }
  return count;
}

int count = CountPositive(5);
Console.WriteLine($"Количество введеных чисел больше нуля: {count}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//            заданных уравнениями 
            // y = k1 * x + b1, 
            // y = k2 * x + b2; 
            // значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindCrossPoint(double k1, double b1, double k2, double b2)
{
  if (k1 == k2 && b1 != b2)
    Console.WriteLine("Прямые параллельны - не имеют точку пересечения");
  else if (k1 == k2 && b1 == b2)
    Console.WriteLine("Прямые совпадают - имеют бесконечное количество пересечений");
  else // Формула Крамера
  {
  double x = -((b1*(-1) - b2*(-1)) / (k1*(-1) - k2*(-1)));
  double y = -((k1*b2 - k2*b1) / (k1*(-1) - k2*(-1)));
  
  Console.WriteLine($"Точка пересечения ({x}, {y})");
  }
}

FindCrossPoint(5, 2, 9, 4);