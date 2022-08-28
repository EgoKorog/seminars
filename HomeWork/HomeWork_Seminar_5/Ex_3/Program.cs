// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double [] array = GetArray(5,10,20);

Console.WriteLine(String.Join(",", array));

Console.WriteLine(String.Join(",", array1(array)));

double[] GetArray(int count, int minValue, int maxValue) // Обьявил условия для массива в методе 1. длина массива 2. мин. значение и макс.значение.
{
    double [] array = new double[count]; // объявил массив array и сказал что он будет равен count то есть его длинне.

    for (int i = 0; i < count; i++) // запустил цикл for (для) внес переменные цикла и задал условия  
    {
        array[i] = new Random(). Next (minValue, maxValue + 1); // условия заполнения цикла
    }

    return array; // возврат 
}

double array1 ( double [] array )
{
    double min = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < min)
        min= array [i];

    }
    double max = array [0];
     for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > max)
        max= array [i];

    }
    return max -min;
}