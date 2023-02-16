/* Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

/* Console.WriteLine("Input Length array");
int size = Convert.ToInt32(Console.ReadLine());

int [] Arr = new int [size];
Random rnd = new Random();

for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = rnd.Next(-100, 101);
    Console.Write(Arr[i] + "    ");
}

Console.WriteLine();

for(int i = 0; i < Arr.Length; i++)
{
    
    Arr[i] = Arr[i] * -1;
    Console.Write(Arr[i] + "    "); */
/* } */


/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */


Console.WriteLine("Input Length array");
int size = Convert.ToInt32(Console.ReadLine());

int [] Arr = new int [size];
Random rnd = new Random();

for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = rnd.Next(0, 101);
    Console.Write(Arr[i] + "    ");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Input nubmer");
int n = Convert.ToInt32(Console.ReadLine());
bool k = false;
for (int i = 0; i < Arr.Length; i++)
{
    if (Arr[i] == n)
    k = true;
    
}
if (k)
{
    Console.WriteLine("Yes");
}
else 
Console.WriteLine("No");