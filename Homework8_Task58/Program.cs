int[,] mas1 = new int[2, 2];
FillArray(mas1);
Console.WriteLine("Первая матрица: ");
PrintArray(mas1);

int[,] mas2 = new int[2, 2];
FillArray(mas2);
Console.WriteLine("Вторая матрица: ");
PrintArray(mas2);

int[,] mas3 = new int[mas1.GetLength(0), mas2.GetLength(1)];
Multipication(mas1, mas2);
Console.WriteLine("Результат умножения: ");
PrintArray(mas3);

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

void Multipication (int[,] mas1, int[,] mas2)
{
    for (int i = 0; i < mas1.GetLength(0); i++)
    {
        for (int j = 0; j < mas2.GetLength(1); j++)

             for (int h = 0; h < mas2.GetLength(0); h++)
                 {
                    mas3[i, j] += mas1[i, h] * mas2[h, j];
                 }
        Console.WriteLine();
    }
}