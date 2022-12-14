// task47


Console.WriteLine("Введите количество строк ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int column = Convert.ToInt32(Console.ReadLine());
double [,] matrix  = new double [row, column];
FillArrayRandomNumbers(matrix);


void FillArrayRandomNumbers(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            Console.Write($"{matrix[i,j]} \t ");
        }
        Console.WriteLine();
    }
}

