// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] InputArray (int length)
{
    int[] array = new int[length];
    Random randon = new Random();
    for (int i = 0; i<length; i++)
    {
        array[i] = randon.Next(1, 30);
    }
    return array;

}

void PrintArray (int[] array)
{
    for (int i = 0; i<=array.Length-1; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int differenceMinMaxToarray (int[] array)
{
    int min = array[1];
    int max = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max< array[i])
        {
            max = array[i];
        }
    }
    return max - min;
}


Console.WriteLine("Полученный массив");
int[] array = InputArray(8);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных местах в массиве - {differenceMinMaxToarray (array)}");