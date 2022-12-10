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

void Zadacha25()
{
    //Задача 25: Используя определение степени числа, напишите цикл, 
    //который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
    //3, 5 -> 243 (3⁵)
    //2, 4 -> 16

    Console.WriteLine("Задача 25.");
    Console.WriteLine("Напишите натуральное число А");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Напишите натуральное число В");
    int numberB = Convert.ToInt32(Console.ReadLine());
    int result = 1;

    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    Console.WriteLine("Число А в степени В = " + result);

}



void Zadacha27()
{
    //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    //452 -> 11
    //82 -> 10
    //9012 -> 12
    Console.WriteLine("Задача 27.");
    Random rand = new Random();
    int number;
    number = rand.Next(10, 10000);
    Console.WriteLine("Рандомное число: " + number);
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    Console.WriteLine("Сумма цифр в числе: " + sum);
}




void Zadacha29()
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -90, 90);
    PrintArray(numbers);

    for (int i = 0; i < size - 1; i++)
    {
        for (int j = 0; j < size - 1 - i; j++)
        {
            if (Math.Abs(numbers[j]) > Math.Abs(numbers[j + 1]))
            {
                int temp = numbers[j];
                numbers[j] = numbers[j+1];
                numbers[j+1] = temp;
            }
        }
    }
    PrintArray(numbers);
}
    Zadacha29();

