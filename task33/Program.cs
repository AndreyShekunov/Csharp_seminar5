// Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

string findResultNumbers(int[] arr, int find)
{
    string findRez = "Нет";
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == find)
        {
            findRez = "Да";
        }
    }
    return findRez;
}

Console.WriteLine("Какое число ищем в массиве?");
int find = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(10, -10, 10); //через метод GetArray заполняем массив array
string res = findResultNumbers(array, find);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(res);