// 
void PrintArrey(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j] }");
        }
        Console.WriteLine();
    }
}
void FillArry(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
        //Console.WriteLine();
    }
}
int[,] matrix = new int[3, 6];
PrintArrey(matrix);
FillArry(matrix);
Console.WriteLine();
PrintArrey(matrix);
