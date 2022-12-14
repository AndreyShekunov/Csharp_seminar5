// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Первый вариант решения
// int[] arr = { 1, 2, 3, 4, 5 }; // исходный массив
// int[] arrNew = new int[(arr.Length + 1) / 2]; // новый массив размером в половину размера исходного массива arr (5+1)/2 = 3

// for (int i = 0; i < arrNew.Length; i++) // цикл заполнения нового массива arrNew
// {
//     arrNew[i] = arr[i] * arr[arr.Length - 1 - i]; // перемножаем первый и последний элемент, потом второй и предпоследний элемент, потом третий на самого себя
// }

// if (arr.Length % 2 != 0) // проверяем полученный массив на четность, если нечетный, то..
// {
//     arrNew[arrNew.Length - 1] = arr[arr.Length / 2]; // .. то присваиваем последнему элементу нового массива значение из страго массива с индексом 2 в данном случае
// }
// Console.WriteLine(string.Join(", ", arrNew));

// Второй вариант решения
int[] arr = { 1, 2, 3, 4, 5 }; 
int[] arrNew = new int[(arr.Length + 1) / 2];

for (int i = 0; i < arrNew.Length; i++)
{
    arrNew[i] = arr[i] * arr[arr.Length - 1 - i];
    if (i == arr.Length-1-i) // проверяем перемножаемых индексов, если они равны, тогда..
    {
        arrNew[i] = arr[i]; // .. тогда просто присваиваем значение из старого массива в новый
    }
}
Console.WriteLine(string.Join(", ", arrNew));