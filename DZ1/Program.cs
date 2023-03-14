// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] InputArray (int length)
{
    int[] array = new int[length];
    Random randon = new Random();
    for (int i = 0; i<length; i++)
    {
        array[i] = randon.Next(100, 999);
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

int findToArray (int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

Console.WriteLine("Полученный массив");
int[] array = InputArray(8);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве - {findToArray (array)}");

