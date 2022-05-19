// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента
int m = 3;
int n = 3;
int l = 3;
int[,,] mass = new int[m, n, l];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j, 0] = new Random().Next(10, 100);
        for (int k = 0; k < mass.GetLength(2); k++)
        {
            mass[i, j, k] = new Random().Next(10, 100);
            for (int a = 0; a < mass.GetLength(0); a++)
            {
                for (int b = 0; b < mass.GetLength(1); b++)
                {
                    for (int c = 0; c < k; c++)
                    {
                        if(mass[i,j,k] == mass[a,b,c])
                        {
                            k--;
                        }
                    }
                }
            }
            Console.Write(mass[i, j, k] + " ");
        }
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();
System.Console.WriteLine("Массив с указанием индексов элементов:");
System.Console.WriteLine();
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int k = 0; k < mass.GetLength(2); k++)
        {
            System.Console.Write($"{mass[i, j, k]} [{i},{j},{k}]" + " ");
        }
    }
    System.Console.WriteLine();
}