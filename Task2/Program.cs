// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.
int m = 3;
int n = 5;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 10);
        System.Console.Write(mass[i, j] + " ");
    }
    System.Console.WriteLine();
}

int minSum = int.MaxValue; 
int indexMinRow = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < mass.GetLength(1); j++)
        sum += mass[i, j];

    if (sum < minSum)
    {
        minSum = sum;
        indexMinRow = i;
    }
    Console.WriteLine($"Сумма строки = {sum};");
}
System.Console.WriteLine($"Минимальная сумма = {minSum}");
Console.WriteLine("Строка с минимальной суммой элементов");
for (int j = 0; j < mass.GetLength(1); j++)
    Console.Write(mass[indexMinRow, j]);
