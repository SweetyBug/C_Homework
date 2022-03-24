int[] masA = new int[8];
int i = 0;
while (i < 8)
{
    if (i + 1 < 3 || i + 1 > 3)
    {
        Console.Write($"Введите {i + 1}-ое число: ");
        masA[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    else if (i + 1 == 3)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        masA[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
}
for (int j = 0; j < masA.Length; j++)
{
    Console.Write(masA[j] + ", ");
}