/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3,21 7,04 22,93 -2,71 78,24] -> 80,95
*/

void Zadacha038()
{
    double[] numbers = {3.21, 7.04, 22.93, -2.71, 78.24};
    PrintArray(numbers);
    
    double minNumber = numbers[0];
    double maxNumber = numbers[0];
    for(int i = 1; i < numbers.Length; i++)
    {
        if(numbers[i] < minNumber) minNumber = numbers[i];
        if(numbers[i] > maxNumber) maxNumber = numbers[i]; 
    }
    Console.WriteLine(Math.Round((maxNumber - minNumber), 2));
}

void PrintArray(double[] nums)
{
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}

Zadacha038();