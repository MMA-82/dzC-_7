Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m, n];
void FillArray (int[,] matr)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-5, 5);
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();    
    }
} 

void SelectionSort (int[,] matr)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            for(int x=j+1; x<matrix.GetLength(1); x++)
            {
                if(matrix[i,j] < matrix[i,x])
                {
                    int temp = matrix[i,j];
                    matrix[i,j] = matrix[i,x];
                    matrix[i,x] = temp;
                }
            }
        }
    }
Console.WriteLine();
}

void PrintArray (int[,] matr)
{
    Console.WriteLine("Матрица со строками, отсортированными по убыванию");
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}
FillArray (matrix);
SelectionSort (matrix);
PrintArray (matrix);