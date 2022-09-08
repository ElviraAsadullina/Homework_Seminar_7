void FindNumber(int[,] array, int m, int n)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(m > array.GetLength(0) ^ n > array.GetLength(1))
                {
                    Console.WriteLine($"Элемент с заданной позицией не найден.");
                    return;
                }
            if(array[i,j] == array[m,n])
            {
                Console.WriteLine($"Элемент с заданной позицией найден и равен: {array[m,n]}");
            }
        }
    }
}
Console.WriteLine("Сгенерирован произвольный массив: ");
int x = new Random().Next(1, 10);
int y = new Random().Next(1, 10);
int[,] elements = new int[x, y];
Random el = new Random();
for(int i = 0; i < x; i++)
{
    for(int j = 0; j < y; j++)
    {
        elements[i,j] = el.Next(-1000, 1000);
        Console.Write(elements[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите первую позицию искомого элемента:");
int findIndex1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую позицию искомого элемента:");
int findIndex2 = Convert.ToInt32(Console.ReadLine());
FindNumber(elements, findIndex1, findIndex2);
