// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве и возвращает 
// значение этого элемента, или же указание, что такого элемента нет.

int row = new Random().Next(2, 15);
int columns = new Random().Next(2, 15);
int[,] array = new int[row, columns];

CreateArray(array);
PrintArray(array);

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 101);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите номер строки для поиска: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца для поиска: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > row || n > columns)
    Console.WriteLine("Элемента с такими координатами в массиве нет");
else
{
    var element = array.GetValue(m - 1, n - 1);
    Console.WriteLine(element);
}