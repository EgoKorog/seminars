// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] array = GetArray(4,100,200);

Console.WriteLine(String.Join(",", array));

Console.WriteLine(String.Join(",", array1(array)));

int[] GetArray(int count, int minValue, int maxValue) // Обьявил условия для массива в методе 1. длина массива 2. мин. значение и макс.значение.
{
    int [] array = new int[count]; // объявил массив array и сказал что он будет равен count то есть его длинне.

    for (int i = 0; i < count; i++) // запустил цикл for (для) внес переменные цикла и задал условия  
    {
        array[i] = new Random(). Next (minValue, maxValue + 1); // условия заполнения цикла
    }

    return array; // возврат 
}

int array1 ( int [] array )
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] %2==0)
        sum+=1;

    }
    return sum;
}
  