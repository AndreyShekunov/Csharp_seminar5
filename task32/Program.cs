// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// Например:
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetArray(int size, int leftRange, int rightRange) // метод заполнения массива случайными числами в диапазоне от leftRange до rightRange
{
    int[] arr = new int[size]; // создаем новый массив размером size
    Random rand = new Random(); // создали переменную рандома rand
    for (int i = 0; i < size; i++) // циклом заполняем наш массив arr случайными цифрами в промежутке от leftRang до rightRange
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr; // возвращаем из метода заполненный массив arr
}


void swapSigns(int[] array) // метод void изменения знаков чесел массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

int[] array = GetArray(10, -10, 10); //через метод GetArray заполняем массив array
Console.WriteLine(string.Join(", ", array));
swapSigns(array);
Console.WriteLine(string.Join(", ", array));