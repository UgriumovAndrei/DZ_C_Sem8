// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/* Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
void PrintArray (int[,]array)
{
for(int i = 0; i<array.GetLength(0); i++)
{
    for(int j = 0; j<array.GetLength(1); j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
} 
Console.WriteLine("Давайте зададим 2 матрицы и перемножим их");
Console.WriteLine("Сколько строк будет в Вашей матрице №1?");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько столбцов будет в Вашей матрице №1?");
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
Console.WriteLine();
Console.WriteLine("Сколько строк будет в Вашей матрице №2?");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько столбцов будет в Вашей матрице №2?");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] array2 = new int [m2,n2];
for(int i = 0; i<array2.GetLength(0); i++)
{
    for(int j = 0; j<array2.GetLength(1); j++)
    {
        array2[i,j] = new Random(). Next(1, 10);
        Console.Write($"{array2[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
if (n != m2) Console.Write("Произведение матриц невозможно - матрицы не согласованы!");
else
{
    Console.WriteLine("Матрица произведения");
    int [,] array3 = new int [m,n2];
    for(int i = 0; i<array3.GetLength(0); i++)
    {
        for(int j = 0; j<array3.GetLength(1); j++)
        {
            int total = 0;
            for(int k = 0; k<array.GetLength(0); k++)
            {
                total+= array[i,k]*array2[k,j];
            }
            array3[i,j] = total;
        }
    }
    PrintArray(array3);
}
