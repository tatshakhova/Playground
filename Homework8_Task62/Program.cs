int[,] mas = new int[4,4];

Spiral(mas);

void Spiral (int[,] arrayname)
{
    int num = 1;
    int i = 0;
    int j = 0;

    while (num < 17)
    {
        arrayname[i, j] = num;

        if (i <= j + 1 && i + j < 3) j++;

        else if (i < j && i + j >= 3) i++;

        else if (i >= j && i + j > 3) j--;

        else i--;

        num++;
    }
}

PrintArray(mas);

void PrintArray(int[,] arrayname)
{
    for (int i = 0; i < arrayname.GetLength(0); i++)
    {
        for (int j = 0; j < arrayname.GetLength(1); j++)
        {
            Console.Write($"{arrayname[i, j]} \t");
        }
        Console.WriteLine();
    }
}
