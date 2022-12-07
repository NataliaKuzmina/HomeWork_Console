void Zadacha21()
{
    Console.WriteLine("ввести координаты первой точки");
    Console.WriteLine("Xa");
    int Xa = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ya");
    int Ya = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Za");
    int Za = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("ввести координаты второй точки");
    Console.WriteLine("Xb");
    int Xb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Yb");
    int Yb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Zb");
    int Zb = Convert.ToInt32(Console.ReadLine());

    double result = Math.Round(Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Zb - Za), 2)), 2);
    Console.WriteLine("Расстояние между точек: " + result);
}




void Zadacha23()
{
    Console.Write("Число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    int result = 1;


    while (count <= N)
    {
        result = count * count * count;
        count++;
        Console.WriteLine("Куб числа: " + result);
    }
}



void Zadacha19()
{

    int number = 98789;
    Console.WriteLine("Число: " + number);

    if (number >= 10000 & number <= 99999)
    {
        int copy_number = number;
        int result = 0;

        while (copy_number > 0)
        {
            int digit = copy_number % 10;
            result = result * 10 + digit;
            copy_number /= 10;
        }
        if (number != result)
        {
            Console.WriteLine("Число не палиндром");
        }
        else
        {
            Console.WriteLine($"Чисто палиндром");
        }
    }
    else
    {
        Console.WriteLine("Число не пятизначное");
    }


}
Zadacha19();