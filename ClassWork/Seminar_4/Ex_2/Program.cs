Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(GetMultiply(num));

int GetMultiply ( int number) //int GetMultiply- метод получения произведения
{
    int result = 1; // строка получения результата 
    for( int i = 1; i <= number; i++)
    {
        result *= i;
    }

   
   
    return result;
}