// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число   : ");
int num = int.Parse(Console.ReadLine());

if (num < 9)
{
    Console.WriteLine("Данное чило не подходит");
}
if (num > 9 && num <= 99)
{
    int num1 = num /10;
    int num2 = num %10;
    int result = num1+num2; 
    Console.WriteLine($"Сумма числа {num} равна {result}");
}
if (num > 99 && num <= 999)
{
    int num1 = num /100;
    int num2 = num / 10;
    int num3 = num2 %10;
    int num4 = num % 10; 
    int result = num1+num3+num4; 
    Console.WriteLine($"Сумма числа {num} равна {result}");
}if (num > 999 && num <= 9999)
{
    int num1 = num  / 1000; // первое число
    int num2 = num / 100;
    int num3 = num2 % 10; // второе число 
    int num4 = num %100;
    int num5 = num4 / 10; // третье число
    int num6 = num5 % 10;
    int result = num1+num3+num5+num6; 
    Console.WriteLine($"Сумма числа {num} равна {result}");
}
else
{
    Console.WriteLine($"Число {num} не подходит");
}