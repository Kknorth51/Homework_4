// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
try
{
Console.WriteLine("Введите  число");
int x = Convert.ToInt32(Console.ReadLine());
int y = 0;
int res (int x)
{
    for (int i = x; i != 0; i = i / 10) y +=i % 10;
        return y;
}
Console.WriteLine($"Сумма чисел в введённой цифре равна [{res (x)}]");
}
catch
{
    Console.WriteLine("Только цифрами, сель ву пле.");
}