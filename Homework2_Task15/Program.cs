Console.WriteLine("Введите число от 1 до 7:");
int x=Convert.ToInt32(Console.ReadLine());
if (x==6||x==7)
{
    Console.WriteLine("Это выходной день.");
}
else if (x>=1 && x<=5)
{
    Console.WriteLine("Это рабочий день.");
}
else Console.WriteLine("Такого дня недели нет.");