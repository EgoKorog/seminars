// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите Координаты А точки");
Console.Write("Введите координаты точки x1 : ");
double x1 = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки y1 : ");
double y1 = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки z1 : ");
double z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите Координаты В точки");

Console.Write("Введите координаты точки x2 : ");
double x2 = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки y2 : ");
double y2 = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки z1 : ");
double z2 = double.Parse(Console.ReadLine());

double c = Math.Sqrt(Math.Pow(x1 - x2,2)+ Math.Pow(y1 - y2,2) + Math.Pow(z1 - z2,2)); // Функция извлечения квадратного корня из числа. Вскобках получаем сумму квадратов.ОСнование степени разность между координатами
Console.WriteLine($" c = {c:f2} ");