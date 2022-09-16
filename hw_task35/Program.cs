// Задача 35: Задайте одномерный массив из 123 случайных чисел
// в диапазоне [0, 150]. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].

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

int numberOfArrayElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99 ) // проверка на значения элементов
        {
            count = count + 1; // считаем количество элементов в заданном о трезке значений
        }
    }
    return count;
}

int[] array = GetArray(123, 0, 150);
Console.WriteLine(string.Join(", ", array));
int count = numberOfArrayElements(array);
Console.WriteLine(count);