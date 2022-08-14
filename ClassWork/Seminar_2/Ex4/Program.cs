Console.Write("Введите первое число "); 
int num1=int.Parse(Console.ReadLine());

Console.Write("Введите первое число "); 
int num2=int.Parse(Console.ReadLine());


if (num1 * num1 == num2)
{
    Console.WriteLine($"{num1} кратно {num2}");
    return;
}

if (Math.Pow(num2, 2) == num1)
{
    Console.WriteLine($"{num1} кратно {num2}");
}
    
    
else 
{
    Console.WriteLine($"{num1} не кратно {num2}");
}




