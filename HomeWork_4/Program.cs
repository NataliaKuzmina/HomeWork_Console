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

Zadacha27();