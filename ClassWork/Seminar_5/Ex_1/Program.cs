// Напишите программу которая создает масив из 12 случайных элементов
//  в диапозоне от -9 до 9 
//  и найдите сумму положительных 
//  и отрицательных элементов.

// int [] array = GetArray(4,-9,9); // Обьявил массив, далее прировнял его к методу GetArray и задал параметры.

// Console.WriteLine(String.Join(",", array));
// Console.WriteLine($"Сумма положительных цифр {GetPosSumm(array)}");
// Console.WriteLine($"Сумма отрицательных цифр {GetNegSumm(array)}");


// int[] GetArray(int count, int minValue, int maxValue) // Обьявил условия для массива в методе 1. длина массива 2. мин. значение и макс.значение.
// {
//     int [] array = new int[count]; // объявил массив array и сказал что он будет равен count то есть его длинне.

//     for (int i = 0; i < count; i++) // запустил цикл for (для) внес переменные цикла и задал условия  
//     {
//         array[i] = new Random(). Next (minValue, maxValue + 1); // условия заполнения цикла
//     }

//     return array; // возврат 
// }

// int GetPosSumm(int [] arr) // Создал метод int GetPosSumm
// {
//     int sum = 0; // ввел новые перменные 

//     for (int i = 0; i < arr.Length; i++) // Условия для цикла for
//     {
//         if ( arr [i] > 0) // условия выполнения 
//         {
//             sum += arr[i];
//         }
//     }
//     return sum;
// }

// int GetNegSumm(int [] arr)
// {
//     int sum = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if ( arr [i] < 0)
//         {
//             sum += arr[i];
//         }
//     }
//     return sum;
// }


int [] array = GetArray(4,-9,9);

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

int [] array1 ( int [] array )
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i]*= -1;
    }
    return array;
}

