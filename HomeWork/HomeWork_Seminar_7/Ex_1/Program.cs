// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// table[1,2] = "Число";

void PrintArray(double [,] tabl)
{
    for (int rows =0; rows < tabl.GetLength(0); rows++)
    {
        for (int colums =0; colums < tabl.GetLength(1); colums++)
        {
            Console.Write($"{tabl[rows, colums]}");
        }
    Console.WriteLine();    
    }

}

void FillArray(double [,] tabl1)
{
    for (int rows =0; rows < tabl1.GetLength(0); rows++)
    {
        for (int colums =0; colums < tabl1.GetLength(1); colums++)
        {
            tabl1[rows,colums]= new Random().Next(-9,10);
        }
    Console.WriteLine();    
    }
}
double [,] table = new double[3,4]; 
PrintArray(table);
FillArray(table);
PrintArray(table);