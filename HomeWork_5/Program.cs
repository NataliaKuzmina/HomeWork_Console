void FindSumPositiveElement(int[] nums)
{
    int sum = 0;
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        if (nums[i] > 0)
        {
            sum += nums[i];
        }

    }
    Console.WriteLine("Сумма позитивных значений: " + sum);
}

void FindSumNegativeElement(int[] nums)
{
    int sum = 0;
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        if (nums[i] < 0)
        {
            sum += nums[i];
        }

    }
    Console.WriteLine("Сумма негативных значений: " + sum);
}

void FillArray(int[] nums, int minValue, int maxValue)
{
    maxValue++;
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
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}


void Zadacha34()
{
    //Задайте массив заполненный случайными положительными трёхзначными числами. 
    //Напишите программу, которая покажет количество чётных чисел в массиве.
    //[345, 897, 568, 234] -> 2
    int size = 3;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 999);
    PrintArray(numbers);
    int count = 0;

    for (int i = 0; i < size; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"В массиве {count} четных чисел");

}



void Zadacha36()
{
    //Задайте одномерный массив, заполненный случайными числами. 
    //Найдите сумму элементов с нечётными индексами.
    //[3, 7, 23, 12] -> 19
    //[-4, -6, 89, 6] -> 0
    int size = 4;
    int[] numbers = new int[size];
    FillArray(numbers, -20, 20);
    PrintArray(numbers);
    int sumNegIndex = 0;

    for (int i = 0; i < size; i++)

        if (i % 2 == 1)
        {
            sumNegIndex += numbers[i];
        }

    Console.WriteLine($"{sumNegIndex} - сумма нечетных индексов");

}

Zadacha36();