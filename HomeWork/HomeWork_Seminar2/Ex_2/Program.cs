// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите любое число "); 
int num = int.Parse(Console.ReadLine());

if (num <= 99)
{
    Console.WriteLine($"Смотри что вводишь третьей цифры нет в двухзначном числе {num} "); 
    return;
}
if (num <= 999)
{
    int num1 = num % 10;
    Console.WriteLine($"Третья цифра числа {num} -> {num1}");
    return;
}
if (num <= 9999)
{
    int num1 = num % 100; 
    int num2 = num1 / 10;
    Console.WriteLine($"Третья цифра числа {num} -> {num2}");
    return;
}
if (num <= 99999)
{
    int num1 = num % 1000; 
    int num2 = num1 / 100;
    Console.WriteLine($"Третья цифра числа {num} -> {num2}");
    return;
}
else
{
    Console.WriteLine($"Число ОЧЕНЬ БОЛЬШОЕ считай сам!");
    return;
}