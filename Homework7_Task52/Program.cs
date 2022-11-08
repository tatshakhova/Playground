Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());


int[,] mas=FillArray(m, n);
PrintArray(mas);
Average(mas);

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];       
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j]= new Random().Next(0,10);
    }
    return array;
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

 void Average (int[,] arrayname)
    {
        
        for (int j = 0; j < arrayname.GetLength(1); j++)
        {
            double sum = 0;
            for (int i = 0; i < arrayname.GetLength(0); i++)
            {
                sum = sum + arrayname [i, j]; 
            }
        Console.WriteLine($"Среднее значение столбца: {sum/m}");
        }
    }

    