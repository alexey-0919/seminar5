int [] Array12 = new int[12];
int plus = 0;
int minus = 0;

Random mas = new Random();

for (int i = 0; i < Array12.Length; i++)
{
    Array12[i] = mas.Next(-9, 10);
    /* Console.Write(Array12[i] + "   "); */
}

/* Console.WriteLine();



for (int i = 0; i < Array12.Length; i++)
if (Array12[i] > 0)
{
    plus = plus + Array12[i];
}
else if (Array12[i] < 0)
{
    minus = minus + Array12[i];
}
else if (Array12[i] == 0);



Console.WriteLine($"Сумма положительных = " + plus);
Console.WriteLine($"Сумма отрицательных = " + minus); */

foreach (var item in Array12)
{
    Console.Write(item + "   ");
}

foreach(var item in Array12)
{
    if (item < 0)
    {
        plus += item;
    }
    else minus += item;
}

Console.WriteLine("\n" + plus + " " + minus);