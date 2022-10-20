// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран


Console.Clear();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0,2);
}

void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write($"{element} ");
}

Console.Clear();

int[] array = new int[8];
FillArray(array);
Console.Write("Массив: ");
PrintArray(array);