// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Write("Введите массив строк через пробел:");
string str = Console.ReadLine();
string[] str_in=str.Split(" ");
int n=3;
int count =0;
for (int i = 0; i < str_in.Length; i++)
{
    if (str_in[i].Length<=n)
    {
        count++;
    }
}
string[] str_out=new string[count];
for (int i = 0, j=0; i < str_in.Length; i++)
{
    if (str_in[i].Length<=n)
    {
        str_out[j]=str_in[i];
        j++;
    }
}
for (int i = 0; i < str_out.Length; i++)
{
    Console.Write(str_out[i]+" ");
}
