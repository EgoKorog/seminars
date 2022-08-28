int [] array = GetArray(4,-9,9);

Console.WriteLine(String.Join(",", array));

Console.WriteLine("Введите искомое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine($"Число {a} найдено ? : {FindElement(a, array)}");

// array1(array);  
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
 bool FindElement ( int digit, int [] array )
{
    
    for (int i = 0; i < array.Length; i++)
    {
        if ( array [i]== a ) return true;
    }   
    return false;
}