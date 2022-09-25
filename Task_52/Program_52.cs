// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rnd.Next(1, 101);
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
}
for (int j = 0; j < n; j++)
{
    double arithmeticAverage = 0;
    for (int i = 0; i < m; i++)
    {
        arithmeticAverage += array[i, j];
    }
    arithmeticAverage = Math.Round(arithmeticAverage / m, 2);
    Console.WriteLine($"Среднее арифметическое столбца № {j + 1} : {arithmeticAverage}");
}