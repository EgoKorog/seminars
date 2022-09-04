// Задача 39 Напишите программу которая перевернет одномерный массив 

int [] array = GetArray(10,0,10);
Console.WriteLine("Исходный массив:");
Console.WriteLine(String.Join(",", array));
Console.WriteLine();
Console.WriteLine("Перевернутый массив:");
// Console.WriteLine(String.Join(",", array1(array)));

int[] GetArray(int count, int minValue, int maxValue) // Обьявил условия для массива в методе 1. длина массива 2. мин. значение и макс.значение.
{
    int [] array = new int[count]; // объявил массив array и сказал что он будет равен count то есть его длинне.

    for (int i = 0; i < count; i++) // запустил цикл for (для) внес переменные цикла и задал условия  
    {
        array[i] = new Random(). Next (minValue, maxValue + 1); // условия заполнения цикла
    }

    return array; // возврат 
}

int[] reversArray = ReversArray2(array);
Console.WriteLine(String.Join(",", reversArray));

ReversArrey1(array);
Console.WriteLine(String.Join(",", array));

void ReversArrey1(int[] inArray)
{
    for ( int i= 0; i < inArray.Length /2; i++  )
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length -i - 1];
        inArray[inArray.Length - i -1] = k; 
    }
}

int [] ReversArray2(int[]inArray)
{
    int[] result = new int[inArray.Length];
    for (int i =0; i< inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length -1 -i];
    }
    return result;
}