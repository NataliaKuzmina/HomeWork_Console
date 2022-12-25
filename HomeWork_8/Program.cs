internal class Program
{
    private static void Main(string[] args)
    {

        void Zadacha53()
        {
            int rows = 4;
            int colums = 5;
            int[,] numbers = new int[rows, colums];
            FillArray(numbers);
            PrintArray(numbers);
            int i1 = 0;
            int i2 = rows - 1;

            for (int j = 0; j < colums; j++)
            {
                (numbers[i1, j], numbers[i2, j]) = (numbers[i2, j], numbers[i1, j]);
            }
            Console.WriteLine();
            PrintArray(numbers);
        }



        void Zadacha55()
        {
            int rows = 4;
            int colums = 4;
            int[,] numbers = new int[rows, colums];
            FillArray(numbers);
            PrintArray(numbers);

            for (int i = 0; i < colums; i++)
            {
                for (int j = i; j < colums; j++)
                {
                    //int temp = numbers[i, j];
                    //numbers[i, j] = numbers[j, i];
                    //numbers[j, i] = temp;

                    (numbers[i, j], numbers[j, i]) = (numbers[j, i], numbers[i, j]);
                }

            }
            Console.WriteLine();
            PrintArray(numbers);


        }




        void Zadacha57()
        {
            int rows = 4;
            int colums = 4;
            int[,] numbers = new int[rows, colums];
            FillArray(numbers, 0, 9);
            PrintArray(numbers);

            int[] dictionary = new int[10];
            PrintArrayDic(dictionary, "Вывод словаря:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    int index = numbers[i, j];
                    dictionary[index]++;
                }

            }
            PrintDictionary(dictionary, "Вывод словаря:");
        }

        void Zadacha54()
        {
            //Задача 54. Задайте двумерный массив. Напишите программу, 
            //которая упорядочит по убыванию элементы каждой строки двумерного массива.
            int rows = 4;
            int columns = 4;
            int[,] numbers = new int[rows, columns];
            int maxIndexRow = rows - 1;
            int maxIndexColumn = columns - 1;

            FillArray(numbers, 0, 9);
            PrintArray(numbers);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < columns - j - 1; k++)
                    {
                        if (numbers[i, k] < numbers[i, k + 1])
                        {
                            int temp = numbers[i, k];
                            numbers[i, k] = numbers[i, k + 1];
                            numbers[i, k + 1] = temp;
                        }
                    }

                }

            }
            Console.WriteLine();
            PrintArray(numbers);
        }



        void Zadacha56()
        {
            //Задача 56. Задайте прямоугольный двумерный массив. 
            //Напишите программу, которая будет находить строку с наименьшей суммой элементов.
            int rows = 4;
            int columns = 7;
            int[,] numbers = new int[rows, columns];
            int sumMin = FindSumInRow(numbers, 0);
            int indexMin = 0;

            FillArray(numbers, 0, 9);
            PrintArray(numbers);


            for (int i = 0; i < rows; i++)
            {

                int sum = 0;
                for (int j = 0; j < columns; j++)
                {
                    sum = sum + numbers[i, j];
                }
                Console.WriteLine("Сумма строки " + sum);

                if (sumMin > sum)
                {
                    sumMin = sum;
                    indexMin = i;
                }

            }
            Console.WriteLine("Сумма минимальной строки: " + sumMin);

        }

        int FindSumInRow(int[,] numbers, int row)
        {
            int sum = 0;
            int columns = numbers.GetLength(1);
            for (int j = 0; j < columns; j++)
            {
                sum = sum + numbers[row, j];
            }
            return sum;
        }
        Zadacha56();
    }
    static void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
    {
        maxValue++;
        Random rand = new Random();
        int rows = numbers.GetLength(0);
        int colums = numbers.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                numbers[i, j] = rand.Next(minValue, maxValue);
            }
        }
    }

    static void PrintArray(int[,] numbers)
    {
        int rows = numbers.GetLength(0);
        int colums = numbers.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.Write($" {numbers[i, j]}\t");
            }
            Console.WriteLine();
        }
    }


    static void PrintArrayDic(int[] numbers, string message = "Вывод мвссива:")
    {
        int rows = numbers.Length;

        Console.WriteLine(message);
        for (int i = 0; i < rows; i++)
        {

            Console.Write($" {numbers[i]}\t");
        }
        Console.WriteLine();

    }

    static void PrintDictionary(int[] numbers, string message = "Вывод массива:")
    {
        int rows = numbers.Length;

        Console.WriteLine(message);
        for (int i = 0; i < rows; i++)
        {
            if (numbers[i] > 0)
                Console.WriteLine($" число {i} встречается: {numbers[i]} раз(-а)");
        }
        Console.WriteLine();
    }
}