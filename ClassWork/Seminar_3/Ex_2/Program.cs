// Задача №2 написать программу которая принимает на вход координаты двух точек и находит растояние между ними в 2D пространстве

Console.WriteLine("Введите Координаты А точки");
Console.Write("Введите координаты точки x1 : ");
double x1 = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки y1 : ");
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите Координаты В точки");

Console.Write("Введите координаты точки x2 : ");
double x2 = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки y2 : ");
double y2 = double.Parse(Console.ReadLine());

double c = Math.Sqrt(Math.Pow(x1 - x2,2)+ Math.Pow(y1 - y2,2)); // Функция извлечения квадратного корня из числа. Вскобках получаем сумму квадратов.ОСнование степени разность между координатами
Console.WriteLine($" c = {c:f3} "); // данное вырожение показывает сколько знаков будет после запятой в данном случае 3, {c:f3}

// double c = Math.Pow(double x, double y); Функция возведения в степень
