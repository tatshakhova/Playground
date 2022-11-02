int a = ReadInt("Введите число A: ");
int b = ReadInt("Введите число B: ");
Degree(a, b);

void Degree(int x, int y)
{
    int result = 1;
    for (int i = 1; i <= y; i++)
    {
        result = result * x;
    }
    Console.WriteLine(result);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}