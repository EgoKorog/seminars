int[] array; // Объявление массива
array = GetBinaryArray(8); //Создание массива через функцию и  обозначение его длинны
 

// Console.WriteLine("Масив из 8 элементов : "); // вывод результата на консоль 1 способ через цикл

// for(int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i]);
// }

Console.WriteLine($"[{string.Join(",", array)}]"); // вывод результата 2 способ в строку

int[] GetBinaryArray( int size) // в самом методе мы создаем и возвращаем массив 
{
    int[] arr = new int[size]; // создание цикла и приравневание его к длинне 
    for(int i =0; i < size; i++) // цикл по заполнению массива 
    {
        arr[i] = new Random().Next(100); // условия заполнения цикла 
    }
    return arr; // return возвращает массив

} 