Console.Write("Введите первое число "); 
int num=int.Parse(Console.ReadLine());

int num1 = 7;
int num2 = 23;

if (num % num1 == 0 && num % num2 == 0)
{
    Console.WriteLine( "Кратно" );
    Console.WriteLine($"число {num} кратно {num1} {num2}  ");
}
else 
{
    Console.WriteLine( "Не кратно");
}

