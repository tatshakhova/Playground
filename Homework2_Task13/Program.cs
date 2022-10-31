Console.WriteLine("Введите число:");
int x=Convert.ToInt32(Console.ReadLine());
if ((x>99) && (x<1000))
{
    Console.WriteLine($"Третья цифра введенного числа: {x%10}");
}
else if (x>1000)
{
    while (x>1000)
       {
        x=x/10;
       } 
    Console.WriteLine($"Третья цифра введенного числа: {x%10}");
}
else Console.WriteLine("Третьей цифры нет :(");
