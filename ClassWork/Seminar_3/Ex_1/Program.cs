// Console.Write("Введите Х: ");
// int x = int.Parse(Console.ReadLine());

// Console.Write("Введите Y: ");
// int y = int.Parse(Console.ReadLine());

// if ( x > 0 && y > 00 )
// {
//     Console.WriteLine( "1 Квадрат ");
// }
// if ( x < 0 && y > 00 )
// {
//     Console.WriteLine( "2 Квадрат ");
// }
// if ( x < 0 && y < 00 )
// {
//     Console.WriteLine( "3 Квадрат ");
// }
// if ( x > 0 && y < 00 )
// {
//     Console.WriteLine( "4 Квадрат ");
// }

// Задание написать программу которая принимает на ввод заданный квадрат и показывает диапозон возможных координат 
Console.Write("Введите квадрат : ");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
   Console.WriteLine (" То Х > 0 а У > 0 " );
} 
if (num == 2)
{
   Console.WriteLine (" То Х < 0 а У > 0 " );
} 
if (num == 3)
{
   Console.WriteLine (" То Х < 0 а У < 0 " );
} 
if (num == 4)
{
   Console.WriteLine (" То Х > 0 а У < 0 " );
} 
else 
{
    Console.WriteLine (" **Такой четверти не существует**" );
}