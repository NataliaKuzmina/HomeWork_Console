/*
void Zadacha63()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int counter = 1;
   
    while (counter <= number)
    {
        Console.Write($"{counter} ");
        counter++;
    }
  
    Recursion(number);
}

void Zadacha65()
{
    // Задайте значения M и N. Напишите программу, которая
    //выведет все натуральные числа в промежутке от M до N.
    Console.WriteLine("Введите число M: ");
    int counter = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Recursion(number, counter);
}


void Recursion(int number, int counter = 1)
{
    if (counter > number) return;
    Console.Write($"{counter} ");
    counter++;
    Recursion(number, counter);
}
 

Zadacha65();

*/

void Zadacha67()
{
    //Задача 67: Напишите программу, которая будет принимать на вход число и
    //возвращать сумму его цифр.
    //453 -> 12
    //45 -> 9
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int sum = 0;
    int current_number = number;
    while (current_number > 0)
    {
        sum += current_number % 10;
        current_number /= 10;
    }
    Console.WriteLine($"Сумма цифр чисел {number} равна {sum}");
    Console.WriteLine();
    Console.WriteLine($"Сумма цифр чисел {number} равна {SumDigits(number)}");

}




void Zadacha69()
{
    //Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
    //возводит число А в целую степень B с помощью рекурсии.
    //A = 3; B = 5 -> 243 (3⁵)
    //A = 2; B = 3 -> 8
    // Задайте значения M и N. Напишите программу, которая
    //выведет все натуральные числа в промежутке от M до N.
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите целую степень число: ");
    int counter = Convert.ToInt32(Console.ReadLine());

}


void Zadacha64()
{
    //Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
    //который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
    Console.WriteLine("Введите первое число: ");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int counter = numberM;

    while (counter <= numberN)
        if (counter % 3 == 0)
        {
            Console.WriteLine($"Натуральные числа кратные 3-ём {counter}");
            counter++;
        }
        else
        {
            counter++;
        }

    PrintMultiples(numberN, counter);

}

int PrintMultiples(int numberN, int counter)
{
    if (counter >= numberN) return counter;

    return PrintMultiples(numberN, counter);
}



void Zadacha66()
{
    //Задача 66: Задайте значения M и N.
    //Напишите рекурсивный метод, который найдёт сумму
    //натуральных элементов в промежутке от M до N.
    Console.WriteLine("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int counter = 1;
    Recursion(number, counter);

    int sum = 0;
    while (counter <= number)
    {
        sum += counter;
        counter++;
    }
    Console.WriteLine($"Сумма цифр чисел {number} равна {sum}");
    Console.WriteLine();
    Console.WriteLine($"Сумма чисел от {number1} до {number} равна {sum}");
}


void Recursion(int number, int counter = 1)
{
    if (counter > number) return;
    Console.Write($"{counter} ");
    counter++;
    Recursion(number, counter);
}


void PrintInterval(int number, int counter = 1)
{
    if (counter > number) return;
    Console.Write($"{counter} ");
    counter++;
    PrintInterval(number, counter);
}


int SumDigits(int number)
{
    if (number == 0) return 0;
    return number % 10 + SumDigits(number / 10);
}


int Akk(int N, int M)
{
    if (N == 0) return M + 1;
    else
    if (N > 0 && M == 0) return Akk(N - 1, 1);
    else
    if (N > 0 && M > 0) return Akk(N - 1, Akk(N, M - 1));

    return Akk(N, M);

}

void Zadacha68()
{
    Console.WriteLine("Введите первое число: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    {
        Akk(N, M);
    }
    Console.WriteLine(Akk(N, M));
}
Zadacha68();


