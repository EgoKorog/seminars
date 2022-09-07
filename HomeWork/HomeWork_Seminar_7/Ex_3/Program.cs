// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите размеры массива");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] table = new int[m,n]; 


// void PrintArray(int [,] tabl)
// {
//     for (int rows =0; rows < tabl.GetLength(0); rows++)
//     {
//         for (int colums =0; colums < tabl.GetLength(1); colums++)
//         {
//             Console.Write($"{tabl[rows, colums]}");
//         }
//     Console.WriteLine();    
//     }

// }

// void FillArray(int [,] tabl1)
// {
//     for (int rows =0; rows < tabl1.GetLength(0); rows++)
//     {
//         for (int colums =0; colums < tabl1.GetLength(1); colums++)
//         {
//             tabl1[rows,colums]= new Random().Next(1,10);
//         }
//     Console.WriteLine();    
//     }
// }

// PrintArray(table);
// FillArray(table);
// PrintArray(table);

static void Main(string[] args)
{
    int[,] mas = new int[3,3] {{1,2,3},{3,5,7},{5,6,1}};
 
    for (int i = 0; i < 3; i++) 
    {
        int srAr = 0;
        int ColChetn = 0;
        for (int t = 0; t < 3; t++)
        {
            srAr += mas[t, i];
            ColChetn += (mas[t, i] % 2 == 0) ? 1 : 0;
        }
        Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr/3}");
        Console.WriteLine($"Количество четных элементов столбца {i + 1} = {ColChetn}");
    }
}

