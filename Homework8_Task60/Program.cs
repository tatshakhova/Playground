int[,,] mas = new int[2, 2, 2];
FillArray(mas);
PrintArray(mas);
    

    
void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
   {
        for (int j = 0; j < array.GetLength(1); j++)
       {
          for (int h = 0; h < array.GetLength(2); h++)
          {
            int[] miniarray = new int[8]; //создание одномерного массива

            for(int ind = 0; ind < 8; ind++)
            {       
                 int number = new Random().Next(10, 100);
                 
                 for(int ind2 = 0; ind2 < 8; ind2++) //проверка случайных элементов на уникальность
                     if (miniarray[ind2] == number)
                     {
                        number++;
                     }
                miniarray[ind] = number;
            array[i, j, h] = miniarray[ind++];
          }
       }
   }
}
}

void PrintArray(int[,,] arrayname)
{
    for (int i = 0; i < arrayname.GetLength(0); i++)
    {
        for (int j = 0; j < arrayname.GetLength(1); j++)
        {
            for (int h = 0; h < arrayname.GetLength(2); h++)
            {
                 Console.Write($"{arrayname[i, j, h]} ({i}, {j}, {h}) ");
            }
        Console.WriteLine();
    }
    }
}