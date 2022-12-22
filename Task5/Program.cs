//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/* Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
void PrintArray (int [,]array)
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
int [,] array = new int [4,4];
int n = 1;
int c = 4;
int ir = 0; 
int jr = 0;
while(c>0)
{
    int help1 =0;
    for(int j = array.GetLength(1) - c; j<c; j++)
    {
        array[ir,j] = n;
        n++;
        help1=j;
    }
    c-=1;
    jr = help1;
    int help2 =0;
    for(int i = array.GetLength(0)-c; i<array.GetLength(0); i++)
    {
        array[i,jr] = n;
        n++;
        help2 = i;
    }
    ir = help2;
    int help3=0;
    for(int j = jr-1 ; j>-1; j--)
    {
        array[ir,j] = n;
        n++;
        help3 = j; 

    }
    c-=1;
    jr = help3;
    int help4=0;
    for(int i = c ; i>0; i--)
    {
        array[i,jr] = n;
        n++;
        help4 = i;
    }
    ir = help4;
   
}
PrintArray(array);