//  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7  Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.WriteLine("Сколько строк будет в Вашем массиве?");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько столбцов будет в Вашем массиве?");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] array = new int [m,n];
for(int i = 0; i<array.GetLength(0); i++)
{
    for(int j = 0; j<array.GetLength(1); j++)
    {
        array[i,j] = new Random(). Next(1, 10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
int mini = 0; 
int minsum = 2000000000;
int sum;
for(int i = 0; i<array.GetLength(0); i++)
{
    sum = 0;
    for(int j = 0; j<array.GetLength(1); j++)
    {
        sum+=array[i,j];
    }
    if(sum<minsum)
    {
        minsum = sum;
        mini = i;
    }
}

Console.WriteLine($"Строка с наименьшей суммой элементов: {mini+1}");
