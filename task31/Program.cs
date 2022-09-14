// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

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

int SumPositiveElements(int[] arr) // метод поиска суммы положительных элементов
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) //если элемент положительный
        {
            sum = sum + arr[i]; //копим сумму положительных элементов
            //sum += arr[i]
        }
    }
    return sum;
}

int SumNegativeElements(int[] arr) // метод поиска суммы отрицательных элементов
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) //если элемент отрицательный
        {
            sum = sum + arr[i]; //копим сумму отрицательных элементов
            //sum += arr[i]
        }
    }
    return sum;
}

int[] array = GetArray(12, -9, 9); //через метод GetArray заполняем массив array
Console.WriteLine(string.Join(", ", array));
int sumPositive = SumPositiveElements(array);
int sumNegative = SumNegativeElements(array);
Console.WriteLine($"Сумма положительных элементов = {sumPositive}, сумма отрицательных элементов = {sumNegative}");