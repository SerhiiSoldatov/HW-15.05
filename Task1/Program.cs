// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

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

System.Console.WriteLine();

var result1 = new int[mass.GetLength(1)];
for (int i = 0; i < mass.GetLength(1); i++)
{
    result1[i] = mass[0, i];
}
// System.Console.WriteLine(string.Join(" ", result1));

var result2 = new int[mass.GetLength(1)];
for (int i = 0; i < mass.GetLength(1); i++)
{
    result2[i] = mass[1, i];
}
// System.Console.WriteLine(string.Join(" ", result2));

var result3 = new int[mass.GetLength(1)];
for (int i = 0; i < mass.GetLength(1); i++)
{
    result3[i] = mass[2, i];
}
// System.Console.WriteLine(string.Join(" ", result3));

System.Console.WriteLine("Элементы строк массива, упорядочиные по убыванию:");
void SelctionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

SelctionSort(result1);
System.Console.WriteLine(string.Join(" ", result1));
SelctionSort(result2);
System.Console.WriteLine(string.Join(" ", result2));
SelctionSort(result3);
System.Console.WriteLine(string.Join(" ", result3));