// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

try
{
Console.WriteLine("Введите  число A ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число B ");
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;
int  res (int a, int b)
{
    for (int i=b; i > 0; i--)
    {
        c *= a;
    }
    return c;
}
Console.WriteLine($"Результат {res(a, b)}");
}
catch
{
  Console.WriteLine("Что-то пошло не так. Введите целое число  ");
}