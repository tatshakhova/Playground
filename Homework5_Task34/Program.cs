

Console.WriteLine("Введите количество элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());

int[] CreateArray()
{
    int[] array = new int[n];

    for(int i = 0; i < n; i++)
    {   
        array[i] = new Random().Next(100, 1000);
        Console.WriteLine($"{array[i]} ");
    }
    return array;
}                
Console.WriteLine();
 
void CountEven(int[] array)
{
    int count = 0;
    foreach(int el in array)
    {
        if (el % 2 == 0) count++;
    }

    Console.WriteLine($"Количество четных чисел в массиве: {count}");

}

int[] mas = CreateArray();
CountEven(mas);