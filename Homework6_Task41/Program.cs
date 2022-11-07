Console.WriteLine("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine()); 

int[] array = new int[m];

for (int i=0; i<m; i++)
    {
        Console.WriteLine("Введите значение элемента массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine()); 
    }

Console.WriteLine("Массив: ");
printarray(array);
Console.WriteLine(" ");

void printarray(int[] arrayname)
{
    for (int i=0; i<m; i++)
    {
        Console.Write(arrayname[i]+" ");
    }   
}

Count(array);

void Count(int[] array)
{
    
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }

    Console.WriteLine($"Количество элементов больше нуля: {count}");
}



