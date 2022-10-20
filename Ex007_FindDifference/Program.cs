// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-99, 100);
}

void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write($"{element} ");
}

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[n];
FillArray(array);
Console.Write("Массив: ");
PrintArray(array);
Console.WriteLine();

int max = array[0];
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (max < array[i]) max = array[i];
    if (min > array[i]) min = array[i];
}
Console.WriteLine($"Разница между максимальным числом ({max}) и минимальным ({min}) = {max-min}");