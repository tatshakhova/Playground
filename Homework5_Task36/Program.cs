

Console.WriteLine("Введите количество элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());

int[] CreateArray()
{
    int[] array = new int[n];

    for(int i = 0; i < n; i++)
    {   
        array[i] = new Random().Next(1, 100);
        Console.WriteLine($"{array[i]} ");
    }
    return array;
}     
 
void Summa(int[] array)
{
    
    int sum = 0;
    for(int i = 0; i < array.Length; i=i+2)
    {
        sum = array[i] + sum;
    }

    Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
}

int[] mas = CreateArray();
Summa(mas);
