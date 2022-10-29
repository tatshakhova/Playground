Console.WriteLine("Введите трехзначное число:");
int x=Convert.ToInt32 ( Console.ReadLine());
int x1 = x%100/10;
Console.WriteLine($"Вторая цифра введенного числа: {x1}");
