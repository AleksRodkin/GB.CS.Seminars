// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNums(int N)
{
  Console.Write(N + " ");
  if (N != 1) ShowNums(N - 1);
}

// ShowNums(10);
// Console.WriteLine();

Console.WriteLine("******************************************************");
Console.WriteLine("Задача 64: Данная программа выводит все натуральные числа в промежутке от N до 1");
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Натуральные числа от N до 1:");
ShowNums(N);
Console.WriteLine();
Thread.Sleep(2200);
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(3000);





// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfNumbers(int M, int N)
{
  if (M != N)
    return SumOfNumbers(M + 1, N) + M;
  return M;
}



Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine("Задача 66: Данная программа находит сумму натуральных чисел в промежутке от M до N");
Console.Write("Задайте значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение N: ");
int newN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Thread.Sleep(1500);
Console.Write($"Сумма натуральных чисел от {M} до {newN} = ");
Console.WriteLine(SumOfNumbers(M, newN));
Console.WriteLine();
Thread.Sleep(2000);
Console.WriteLine("******************************************************");
Console.WriteLine();
Console.WriteLine("Загрузка следующей задачи...");
Thread.Sleep(3000);



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermannFunc(int m, int n)
{
  if (m == 0)
   return n + 1;
  
  if (m > 0 && n == 0)
    return AckermannFunc(m - 1, 1);

  if (m > 0 && n > 0)
    return AckermannFunc(m - 1, AckermannFunc(m, n - 1));

  return -1;
}

Console.WriteLine();
Console.WriteLine("******************************************************");
Console.WriteLine("Задача 68: Данная программа вычисляет функцию Аккермана");
Console.WriteLine("Фунция принимает два неотрицательных числа m и n");
Console.Write("Задайте значение m (от 0 до 3): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение n (от 0 до 10): ");
int n = Convert.ToInt32(Console.ReadLine());
int ackermannResult = AckermannFunc(m, n);
Thread.Sleep(2000);
Console.WriteLine();
Console.Write($"Результат вычисления функции Аккермана({m},{n}) = {ackermannResult}");
Console.WriteLine();
Thread.Sleep(2200);
Console.WriteLine();
Console.WriteLine("*** Ну вот и всё, ребята! Спасибо, что были с нами! ***");
Console.WriteLine();
