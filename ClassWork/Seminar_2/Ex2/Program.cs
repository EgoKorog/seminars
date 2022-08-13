Console.Write("Введите первое число "); 
int number1=int.Parse(Console.ReadLine());

Console.Write("Введите второе число "); 
int number2=int.Parse(Console.ReadLine());

if (number1 % number2 == 0 )
{
    Console.Write("Кратно"); 
}
else 
{
    Console.Write($"Не Кратно, остаток {number1 % number2}"); 
}
