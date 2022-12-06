Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 10000 || number > 99999)
{
    Console.Write("Число неверное. Введите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
string str = Convert.ToString(number);
if (str[0] == str[4] && str[1] == str[3])
    Console.WriteLine("Это число - палиндром!");
else
    Console.WriteLine("Это число - не палиндром :( ");

