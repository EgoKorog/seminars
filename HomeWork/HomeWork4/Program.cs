//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
//                0   1   2   3   4   5   6   7   8   9
//int[] array = { 12, 32, 13, 44, 51, 67, 75, 83, 29, 44 };
//int n = array.Length;
//int find = 44;

Console.Write("Введите N:  ");
int N = int.Parse(Console.ReadLine()); 

int i = 1;
while ( i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    i ++;
}
Console.WriteLine();

