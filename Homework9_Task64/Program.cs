Console.Write ("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());

string Rec(int n)
{
if (n == 0) return "";
return Convert.ToString(n) + " " + Rec(n-1);
}

Console.WriteLine(Rec(n));

