Console.WriteLine("Введите число:");
int x=Convert.ToInt32(Console.ReadLine());
int x1=x/10000;
int x2=x%10000/1000;
int x4=x%100/10;
int x5=x%1000%10;
if ((x1==x5) && (x2==x4))
    Console.WriteLine("это палиндром");
else
    Console.WriteLine("это не палиндром");
