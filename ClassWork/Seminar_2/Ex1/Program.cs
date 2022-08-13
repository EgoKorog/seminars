int num = new Random().Next ( 100, 1000);

//int a = num / 100;
//int b = num % 10;

//int max = a;
//if (max < b)
//{
    //max = b;
//}

//Console.WriteLine($"Максимальная цифра равна {max} слусайное число {num}");
//Console.WriteLine($"Случайная цифра {num} ");
//Console.WriteLine($"{a}{b}");

int a = num / 10;
int a1 = a / 10;

int b = num / 10;
int b1 = b % 10;

int c = num % 10;

Console.WriteLine($"Случайная число {num} ");
Console.WriteLine($"{a1}");
Console.WriteLine($"{b1}");
Console.WriteLine($"{c}");
Console.WriteLine($"Случайное число без второй цифры {a1}{c}");

int result = (num/100) * 10 + num % 10;
Console.WriteLine($"{num} -> {result}");
