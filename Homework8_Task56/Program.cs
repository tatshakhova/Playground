int[,] mas=new int[4, 4];
FillArray(mas);
PrintArray(mas);
MinSum(mas);

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

 void MinSum (int[,] arrayname)
    {
        int min = 37; //т.к. максимальная сумма ряда 36
        int index = 0;

        for (int i = 0; i < arrayname.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < arrayname.GetLength(1); j++)
            {
                sum = sum + arrayname [i, j]; 
            }
            
            if (sum < min)
            {
                min = sum;
                index = i;
            }
        }
    
    Console.WriteLine($"Минимальная сумма элементов находится в строке {index+1}.");   
    
    }

    