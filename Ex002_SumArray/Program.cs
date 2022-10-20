// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0,10);
}

void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write($"{element} ");
}

int SumPositiveArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        sum = sum + array[i];
    }
    return sum;
}

int SumNegativeArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        sum = sum + array[i];
    }
    return sum;
}

Console.Clear();

int[] array = new int[12];
FillArray(array);
Console.Write("Массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов = {SumPositiveArray(array)}");
Console.WriteLine($"Сумма отрицательных элементов = {SumNegativeArray(array)}");