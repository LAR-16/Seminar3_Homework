Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int x = 1;
while (x <= n)
{
    Console.WriteLine(Math.Pow(x, 3));
    x ++;
}