// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

//int number;
//Console.Write("Введите число "); 
//number = Console.ReadLine();

//if ( number % 2 == 1 )
//{
    //ConsoleApplication1.writeLine("Число четное");
//}
//else 
//{
    //ConsoleApplication1.writeLine("Число нечетное");
//}

//Console.ReadKey();

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;                             
            Console.Write("введите число: ");
            a= Console.Read();
 
            if (a % 2==1)
            {
                Console.WriteLine("число нечетное");
           
            }
            else
            {
                Console.WriteLine("Число четное");
            }
 
            Console.ReadKey();
        }
    }
}