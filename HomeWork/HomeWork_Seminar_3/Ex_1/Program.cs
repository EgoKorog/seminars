// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int num1 = num / 1000; 
Console.WriteLine ($" Первые цифры числа {num1} " );

int num1a = num1 / 10; 
Console.WriteLine ($" Первая цифра числа {num1} -> {num1a} " );

int num1b = num1 % 10; 
Console.WriteLine ($" Вторая цифра числа {num1} -> {num1b} " );


int num2 = num % 100; 
Console.WriteLine ($" Последии две цифры цисла {num2} " );

int num2a = num2 / 10; 
Console.WriteLine ($" Первая цифра числа {num2} -> {num2a} " );

int num2b = num2 % 10; 
Console.WriteLine ($" Вторая цифра числа {num2} -> {num2b} " );

if ( num1a == num2a || num1a == num2b)
{
    if ( num1b == num2a || num1b == num2b)
    Console.WriteLine ($" Число {num} являеться палиндромом " );
}
else
{
    Console.WriteLine ($" Число не {num} являеться палиндромом " );
}

