int[] array = new int[8];

for (int i=0; i<8; i++)
    {
        Console.WriteLine("Введите значение элемента массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine()); 
    }

printarray(array);

void printarray(int[] arrayname)
{
    for (int i=0; i<8; i++)
    {
        Console.Write(arrayname[i]+" ");
    }   
}


