Console.Write("Введите число, которое будет возводиться в степень: ");
int numbA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int numbB = Convert.ToInt32(Console.ReadLine());
int n = numbA;
if (numbB == 0)
{
    Console.WriteLine('1');
}
else
{
    for (int i = 2; i <= numbB; i++)
    {
        numbA = numbA * n;
    }
    Console.WriteLine(numbA);
}