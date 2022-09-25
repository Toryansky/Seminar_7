// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

Console.Write("Введите количество строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = Math.Round(rnd.NextDouble() * 1000 - 500, 2);
        Console.Write("{0, 10}", array[i, j]);
    }
    Console.WriteLine();
}