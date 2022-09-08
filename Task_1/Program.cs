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
double[,] nums = new double[m, n];
Random num = new Random();
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        nums[i,j] = num.Next(-10, 10) + num.NextDouble();
        nums[i,j] = Math.Round(nums[i,j], 1);
    }
}
Console.WriteLine("Полученный двумерный массив: ");
PrintTwoDimArray (nums);