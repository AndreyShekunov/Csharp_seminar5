// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// Например:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int sumOfOddArrayPositions(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int[] array = GetArray(4, -4, 100);
Console.WriteLine(string.Join(", ", array));
int sum = sumOfOddArrayPositions(array);
Console.WriteLine(sum);