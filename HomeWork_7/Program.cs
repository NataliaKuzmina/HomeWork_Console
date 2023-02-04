
internal class Program
{
    static void FillArray(double[,] numbers, int minValue = 0, int maxValue = 9)
    {
        maxValue++;
        Random rand = new Random();
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                //Console.WriteLine($"[{i}, {j}]");
                numbers[i, j] = Math.Round(rand.NextDouble() * maxValue, 1);
            }
        }
    }


    static void PrintArray(double[,] numbers, string message = "Вывод массива: ")
    {
        int rows = numbers.GetLength(0);
        int colums = numbers.GetLength(1);
        Console.WriteLine();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                //Console.WriteLine($"[{i}, {j}]");
                Console.Write($" {numbers[i, j]}\t");
            }
            Console.WriteLine();
        }
    }


    static void PrintArray(int[,] numbers, string message = "Вывод массива: ")
    {
        int rows = numbers.GetLength(0);
        int colums = numbers.GetLength(1);
        Console.WriteLine();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                //Console.WriteLine($"[{i}, {j}]");
                Console.Write($" {numbers[i, j]}\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }


    static void FillArray(double[] numbers, int minValue = 0, int maxValue = 9)
    {
        maxValue++;
        int size = numbers.Length;
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            double value = random.NextDouble() * 20 - 10;
            numbers[i] = Math.Round(value, 2);
        }
    }

    static void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
    {
        maxValue++;
        int size = numbers.Length;
        Random random = new Random();
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"[{i}, {j}]");
                numbers[i, j] = random.Next(minValue, maxValue);
            }
        }
    }


    private static void Main(string[] args)
    {


        void Zadacha47()
        {
            //Задача 47: Задайте двумерный массив размером m×n, 
            //заполненный случайными вещественными числами, округлёнными до одного знака.

            int rows = 3;
            int columns = 4;
            int maxIndexRow = rows - 1;
            int maxIndexColumn = columns - 1;
            double[,] numbers = new double[rows, columns];
            FillArray(numbers);
            PrintArray(numbers);

        }



        void Zadacha50()
        {
            int rows = 5;
            int columns = 5;
            int maxIndexRow = rows - 1;
            int maxIndexColumn = columns - 1;
            double[,] numbers = new double[rows, columns];
            FillArray(numbers, 10, 100);
            PrintArray(numbers);

            int indexX = 4;
            int indexY = 3;

            if (indexX >= 0 && indexY >= 0 &&
                indexX < rows && indexY < columns)
            {
                Console.WriteLine($"Элемент равен {numbers[indexX, indexY]}");
            }
            else
            {
                Console.WriteLine($"Введены неверные индексы");
            }
        }


        void Zadacha52()
        {
            int rows = 2;
            int columns = 2;
            int maxIndexRow = rows - 1;
            int maxIndexColumn = columns - 1;
            int[,] numbers = new int[rows, columns];
            FillArray(numbers);
            PrintArray(numbers);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
                Console.WriteLine();
            }
        }
        Zadacha52();
    }
}