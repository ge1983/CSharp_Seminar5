// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

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

int sumToArray (int[] array)
{
    int sum = 0;
    int index = 1;
    while (index < array.Length)
    {
        sum = sum + array[index];
        index = index +2;
    }
    return sum;
}


Console.WriteLine("Полученный массив");
int[] array = InputArray(8);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных местах в массиве - {sumToArray (array)}");