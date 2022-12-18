
void Zadacha41()
{
    Console.WriteLine("Напишите количество чисел: ");
    int count = Convert.ToInt32(Console.ReadLine());
    int counterAboveZero = 0;
    for (int i = 1; i <= count; i++)
    {
        Console.WriteLine($"Введите {i}-ое число:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) counterAboveZero++;
    }
    Console.WriteLine($"Вы ввели {counterAboveZero} чисел больше 0.");
}





void Zadacha43()
{
    int k1 = 6;
    int b1 = 6;
    int k2 = 1;
    int b2 = 9;
    if (k1 != k2)
    {
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения прямых ({x},{y})");   
    }
    else
    {
         Console.WriteLine($"Точка пересечение отсутствует");
    }
}

Zadacha43();

