/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

/* int [] Arr = new int [123];
Random rnd = new Random();

for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = rnd.Next(0, 10000);
    if (i < Arr.Length-1)
    Console.Write(Arr[i] + " , ");
    else
    Console.Write(Arr[i] + " ");
}

Console.WriteLine();
Console.WriteLine();

int count = 0;
for (int i = 0; i < Arr.Length; i++)
{
    if (Arr[i] < 100 && Arr[i] > 9)
    count = count + 1;
}
Console.WriteLine($"Количество элементов = " + count); */


/* Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

/* int size = Convert.ToInt32(Console.ReadLine());

int [] Arr = new int [size];
Random rnd = new Random();

for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = rnd.Next(0, 10);
    Console.Write(Arr[i] + "    ");
}

Console.WriteLine();

int proiz = 0;
int [] NArr = new int [Arr.Length/2+1];


if (Arr.Length % 2 == 0)
{
for(int i = 0; i < Arr.Length/2; i++)
{
    proiz = Arr[i] * Arr[Arr.Length - i - 1];
    NArr[i] = proiz;
    Console.Write(NArr[i] + "    ");
}
}
else 
{
    
for(int i = 0; i < (Arr.Length/2)+1; i++)
{
    if (i < Arr.Length/2) 
    { 
    proiz = Arr[i] * Arr[Arr.Length - i - 1];
    NArr[i] = proiz;
    Console.Write(NArr[i] + "    ");
    }
    else if (i == Arr.Length/2)
    {
        NArr[i] = Arr[i];
       Console.Write(NArr[i] + "    "); 
    }
    
}
}
 */

/* int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
for (int i = 0; i < size; i ++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write(array[i] + "   ");
}
 */


string str = Console.ReadLine();

var arr = str.Split(" ");

int[] arrint = new int [arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    arrint[i] = Convert.ToInt32(arr[i]);
}

foreach (var item in arrint)
{
    System.Console.WriteLine(" " + item);
}