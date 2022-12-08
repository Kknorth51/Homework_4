// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и 
// далее выводит массив на экран в одну строк

void CheckArray()
{
Console.WriteLine("Введите массив из восьми чисел");
int[] n = new int[8];
for (int i = 0; i < 8; i++)
{
    n[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"[{n[0]},{n[1]},{n[2]},{n[3]},{n[4]},{n[5]},{n[6]},{n[7]}]");
}
CheckArray();