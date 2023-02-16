string str = "hello";

/* str[1] = 'o'; */ //не работает

char[] arrChar = str.ToCharArray();

arrChar[1] = 'o';

foreach (var item in arrChar)
{
    Console.Write(item);
}