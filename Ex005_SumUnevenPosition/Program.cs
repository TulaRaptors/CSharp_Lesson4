//  Найти сумму чисел одномерного массива стоящих на нечетной позиции

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

int SumUnevenPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2) // Элемент стоит на 1-й позиции, но имеет индекс 0, поэтому считаем чётные индексы.
        sum += array[i];
    return sum;
}

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[n];
FillArray(array);
Console.Write("Массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма чисел стоящих на нечётной позиции = {SumUnevenPosition(array)}");