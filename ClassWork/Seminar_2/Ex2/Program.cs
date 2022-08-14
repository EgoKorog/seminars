//Console.Write("Введите первое число "); 
//int number1=int.Parse(Console.ReadLine());

//Console.Write("Введите второе число "); 
//int number2=int.Parse(Console.ReadLine());

//if (number1 % number2 == 0 )
//{
//    Console.Write("Кратно"); 
//}
//else 
//{
  //  Console.Write($"Не Кратно, остаток {number1 % number2}"); 
//}

Console.Write("Введите первое число "); 
int number=int.Parse(Console.ReadLine());

if (number % 7 == 0 )
{
    Console.Write("Кратно");
    else 
    {
        Console.Write($"Не Кратно, остаток {number % 7}");
    }
    if (number % 23 == 0 )
    {
        Console.Write("Кратно");
    }
     else
     {
        Console.Write($"Не Кратно, остаток {number % 23}");
     }
}

