int[,] mas = new int[4, 4];
FillArray(mas);
PrintArray(mas);
SortMaxMin(mas);
Console.WriteLine();
PrintArray(mas);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortMaxMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(1) - 1; h++)
            {
                if (array[i, h] < array[i, h + 1])
                {
                    int temp = array[i, h + 1];
                    array[i, h + 1] = array[i, h];
                    array[i, h] = temp;
                }
            }
        }
    }
}
