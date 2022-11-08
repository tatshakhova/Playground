Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] FillArray(int m, int n)
{
    double[,] array = new double[m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
            double a = new Random().Next(1, 10);
            array[i,j] = (new Random().Next(-10, 10))*0.01+a;
            }
    }
    return array;
}

void PrintArray(double[,] arrayname)
{
    for (int i = 0; i < arrayname.GetLength(0); i++)
    {
        for (int j = 0; j < arrayname.GetLength(1); j++)
        {
            Console.Write($"{arrayname[i, j]} \t");
            // if (image[i, j]<10 && image[i, j]>=0) Console.Write($"{image[i, j]} \t");
            // else if (image[i, j]<-9) Console.Write($"{image[i, j]} ");
            // else Console.Write($"{image[i, j]}  ");
        }
        Console.WriteLine();
    }
}

double[,] mas=FillArray(m,n);
PrintArray(mas);