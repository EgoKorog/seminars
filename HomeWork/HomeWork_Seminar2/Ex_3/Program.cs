// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
// String [] Weekdays = { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
// int [] Weekdays = { 1, 2, 3, 4, 5, 6, 7 };

// int n = Weekdays.Length;
Console.Write("Введите число от 1 до 7: -> "); 
int num = int.Parse(Console.ReadLine());



// int monday;
// int tuesday; 
// int wednesday; 
// int thursday; 
// int friday; 
// int saturday; 
// int sunday; 

// int monday = 1 ;
// int tuesday; 
// int wednesday; 
// int thursday; 
// int friday; 
// int saturday; 
// int sunday;  
if (num == 6)
{
    Console.WriteLine($" Сегодня Суббота "); 
    return;
}
if (num >= 6)
{
    Console.WriteLine($" Сегодня Воскресенье "); 
    return;
}
else 
{
    Console.WriteLine($" Топай на работу! "); 
    return;
}






// int Monday = 0;
// int Tuesday = 1;
// int Wednesday = 2;
// int Thursday = 3;
// int Friday = 4;
// int Saturday = 5;
// int Sunday =6;