// Задача 38: Задайте массив натуральных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// Например:
// [3 7 22 2 78] -> 76

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

int differenceMinAndMax(int[] arr) //метод ищет минимум и максимум, а потом ищет разницу между ними
{
    int min = arr[0];
    int max = arr[0];
    int diff = 0;
    for (int i = 0; i < arr.Length; i ++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
        }
        if(arr[i] > max)
        {
            max = arr[i];
        }
    }
    diff = max - min;
    return diff;
}

int[] array = GetArray(4, 1, 100);
Console.WriteLine(string.Join(", ", array));
int diffrence = differenceMinAndMax(array);
Console.WriteLine(diffrence);