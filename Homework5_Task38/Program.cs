Console.WriteLine("Введите количество элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Массив: ");

double[] CreateArray(int n)
{
    double[] array = new double[n];

    for(int i = 0; i < n; i++)
    {   
        double a = new Random().Next(1, 10);
        array[i] = new Random().NextDouble() + a;
        Console.WriteLine($"{array[i]} ");
    }
    return array;
}     
 
void Difference(double[] array)
{  
    double max = array[0];
    double min = array[0];

    for(int i = 0; i < array.Length; i++)
    {   
        if (array[i] >= max) max = array[i];
        if (array[i] <= min) min = array[i];
    }     
    Console.WriteLine($"Максимум: {max}");
    Console.WriteLine($"Минимум: {min}");
    Console.WriteLine($"Разница: {max - min}");
}


double[] mas = CreateArray(n);
Difference(mas);
