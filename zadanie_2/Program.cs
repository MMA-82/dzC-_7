Console.Write("Введите число строк: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов: ");
int b = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[a, b];
void FillArray (int[,] matr)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();    
    }
}
FillArray(matrix);
Console.WriteLine();
if(a != b) Console.WriteLine("В данной матрице нельзя заменить строки столбцами!");
else
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=i; j<matrix.GetLength(1); j++)
        {
            int zamena = matrix[i, j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] = zamena;
        }
    }
    void PrintArray (int[,] matr)
    {
        Console.WriteLine("В матрице строки со столбцами поменяли местами:");
        for(int i=0; i<matrix.GetLength(0); i++)
        {
            for(int j=0; j<matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
        Console.WriteLine();
        }
    }
    PrintArray(matrix);        
}

