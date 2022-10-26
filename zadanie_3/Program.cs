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

if(a!=b)
{
    int[] sumstrok = new int[matrix.GetLength(0)];
    int sum = 0;
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
        }
    sumstrok[i] = sum;
    //Console.Write($"{sumstrok[i]} ");
    sum = 0;    
    }
    //Console.WriteLine();
    
    int min = sumstrok[0];
    int pos = 0;
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        if(min > sumstrok[i])
        { 
            min = sumstrok[i];
            pos = i + 1;
        } 
    }    
    Console.Write($"Наименьшая сумма элементов в троке № {pos} = " + min);
}
else Console.WriteLine("Матрица не прямоугольная!!!");


