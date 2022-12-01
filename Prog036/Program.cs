/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void Zadacha036()
{
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers, 1, 10);
    PrintArray(numbers);

    int summ = 0;
    for(int i = 0; i < size; i++)
    {
        if(i % 2 != 0) summ += numbers[i];
    }
    Console.WriteLine(summ);
}

void FillArray(int[] nums, int minValue, int maxValue)
{
    Random rand = new Random();
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        nums[i] = rand.Next(minValue, maxValue);
    }
}

void PrintArray(int[] nums)
{
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}

Zadacha036();