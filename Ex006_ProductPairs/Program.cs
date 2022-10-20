// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
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
for (int i = 0; i < array.Length / 2; i++)
{
    int prod = array[i] * array[array.Length - 1 - i];
    Console.WriteLine($"Произведение пары {array[i]} и {array[array.Length - 1 - i]} = {prod}");
}