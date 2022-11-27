void Zadacha2()
{
    // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

    Console.WriteLine("Задача 2.");
    Console.WriteLine("Первое число");
    int numberFirst = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Второе число");
    int numberSecond = Convert.ToInt32(Console.ReadLine());

    if (numberFirst > numberSecond)
    {
        Console.WriteLine($"{numberFirst} == max {numberSecond} == min");
    }
    else
    {
        Console.WriteLine($"{numberSecond} == max {numberFirst} == min");
    }

}




void Zadacha4()
{
    // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    Console.WriteLine("Первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Второе числ: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Третье число: ");
    int c = Convert.ToInt32(Console.ReadLine());
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;

    Console.WriteLine("Максимальное число: " + max);
}



void Zadacha6()
{
    //  Напишите программу, которая на вход принимает число и выдаёт, 
    //является ли число чётным (делится ли оно на два без остатка).

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number % 2 == 0)
    {
        Console.WriteLine($"число {number} четное");
    }
    else
    {
        Console.WriteLine($"число {number} нечетное");
    }
}





void Zadacha8()
{
    // Напишите программу, которая на вход принимает число (N > 0), 
    //а на выходе показывает все чётные числа от 1 до N.

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    while (count <= number)
    {
        if (count % 2 == 0)
            Console.WriteLine(count + " ");
        count++;
    }

}
Zadacha6();
