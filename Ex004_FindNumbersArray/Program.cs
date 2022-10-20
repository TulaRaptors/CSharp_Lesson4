// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}

void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write($"{element} ");
}

int FindElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
            count++;
    }
    return count;
}

Console.Clear();

int[] array = new int[123];
FillArray(array);
Console.Write("Массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество элементов из отрезка [10,99] = {FindElements(array)}");