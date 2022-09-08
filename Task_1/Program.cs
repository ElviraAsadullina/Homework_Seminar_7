void PrintTwoDimArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Заролните массив любыми вещественными числами через Enter: ");
double[,] nums = new double[m, n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        nums[i,j] = Convert.ToDouble(Console.ReadLine());
    }
}
Console.WriteLine("Полученный двумерный массив: ");
PrintTwoDimArray (nums);