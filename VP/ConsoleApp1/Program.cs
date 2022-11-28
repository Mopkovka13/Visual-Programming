

double[,] matrix = { { 1, 2, 3 }, { 2, 1, 3 }, { 3, 2, 1 } };
double[,] matrix2 = matrix;
matrix2[0, 0] = 5;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for(int j = 0; j < matrix2.GetLength(1); j++)
    {
        Console.Write(matrix2[i,j] + " ");
    }
    Console.WriteLine();
}
