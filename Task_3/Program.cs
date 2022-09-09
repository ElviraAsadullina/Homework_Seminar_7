Console.WriteLine("Сгенерирован произвольный массив: ");
int m = new Random().Next(1, 6);
int n = new Random().Next(1, 6);
int[,] integer = new int[m, n];
Random integ = new Random();
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        integer[i,j] = integ.Next(1, 10);
        Console.Write(integer[i, j] + "\t");
    }
    Console.WriteLine();
}
double avg = 0;
for(int j = 0; j < n; j++)
{
    double sum = 0;
    for(int i = 0; i < m; i++)
    {
        sum += integer[i, j];
    }
    avg = sum / m;
    Console.WriteLine($"Среднее арифметическое элементов в столбце {j} = {avg}");
}