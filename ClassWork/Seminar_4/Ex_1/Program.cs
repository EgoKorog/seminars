// Напишите программу, которая принимает на вход число и выдает количество цифр в числе. 
// 25
//432
// 5252


// Первый вариант решения


// Console.WriteLine("Введите число");
// string num = Console.ReadLine();

// int length = num.Length;

// Console.WriteLine($"{length} "); 


// Второй вариант решения 

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(GetCount(num));

int GetCount( int number) //int GetCount- метод подсчитывания количества цифр в числе
{
    int count = 0;

    while (number > 0 )
    {
        count++;
        number /= 10;
    }
    return count;
}

