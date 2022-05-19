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
for (int i = 0; i < mass.GetLength(0); i++)
{

    for (int j = 0; j < mass.GetLength(1); j++)
    {
        
    }
    System.Console.WriteLine();
}
// int[] ara = new int[] {mass[0,n]};
// System.Console.Write(ara);
// foreach (var i in ara)
// {
//     Console.Write("{0} ", i);
// }
// Console.WriteLine();
// Array.Sort(ara);
// Array.Reverse(ara);
// foreach (var i in ara)
// {
//     Console.Write("{0} ", i);
// }
// Console.WriteLine();
// Console.ReadKey();
// return 0;
