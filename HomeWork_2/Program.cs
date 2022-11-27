//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void Zadacha10()
{
    Console.WriteLine("Задача 10.");
    Random rand = new Random();
    int number;
    number = rand.Next(100, 1000);
    Console.WriteLine("Рандомное трёхзначное число: " + number);
    int a = number / 10;
    int b = a % 10;

    Console.WriteLine("Вторая цифра этого числа: " + b);

}


void Zadacha10_1()
{
    Console.WriteLine("Задача 10.");
    Console.WriteLine("Напешите трёхзначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Трёхзначное число: " + number);
    int a = number / 10;
    int b = a % 10;

    Console.WriteLine("Вторая цифра этого числа: " + b);

}
Zadacha10_1();


// Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.



void Zadacha13()
{
    Console.WriteLine("Задача 13.");
    Console.WriteLine("Напешите число");
    int number = Convert.ToInt32(Console.ReadLine());


    if (number < 100)
    {
        Console.WriteLine("В числе нет третьей цифры");
    }
    else if (number < 1000)
    {
        Console.WriteLine("Третья цифра числа: " + number % 10);
    }
    else if (number < 10000)
    {
        Console.WriteLine("Третья цифра числа: " + number / 10 % 10);
    }
    else if (number < 100000)
    {
        Console.WriteLine("Третья цифра числа: " + number / 100 % 10);
    }
}


void Zadacha13_1()
{
    Console.WriteLine("Задача 13.");
    Random rand = new Random();
    int number = rand.Next(10, 100000);
    Console.WriteLine(number);

    if (number < 100)
    {
        Console.WriteLine("В числе нет третьей цифры");
    }
    else if (number < 1000)
    {
        Console.WriteLine("Третья цифра числа: " + number % 10);
    }
    else if (number < 10000)
    {
        Console.WriteLine("Третья цифра числа: " + number / 10 % 10);
    }
    else if (number < 100000)
    {
        Console.WriteLine("Третья цифра числа: " + number / 100 % 10);
    }

}


//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Zadacha15()
{
    Console.WriteLine("Задача 15.");
    Random rand = new Random();
    int number = rand.Next(0, 8);
    Console.WriteLine(number);

    if (number > 0 && number < 6)
    {
        Console.WriteLine("Будний день");
    }
    else if (number == 6 || number == 7)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("не корректное число");
    }

}
Zadacha15();

