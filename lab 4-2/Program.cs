Console.WriteLine("Введите размерность матрицы N:");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];

Console.WriteLine("Введите элементы матрицы:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Исходная матрица:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Зеркально отраженная матрица:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[n - j - 1, n - i - 1] + " ");
    }
    Console.WriteLine();
}