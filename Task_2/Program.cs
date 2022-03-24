Console.WriteLine("Введите число: ");
string? str = Console.ReadLine();
int len = str.Length;
int numb = Convert.ToInt32(str);

int n = 1;
int k = 0;
int j = 0;

if (len == 1) Console.Write(numb);
else
{
    for (int i = 1; i < len; i++)
    {
        n = n * 10;
    }

    while(j < len)
    {
        k += numb / n;
        numb = numb % n;
        n = n / 10;
        j++;
    }
Console.WriteLine(k);
}