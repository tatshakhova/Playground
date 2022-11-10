Console.Write ("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int Rec(int m)
{
if (m == n + 1) return 0;
return m + Rec(m + 1);
}

Console.WriteLine(Rec(m));
