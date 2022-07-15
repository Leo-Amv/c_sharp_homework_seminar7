namespace Homework
{
    public class Methods
    {
        /// <summary>Метод печатает int массив в консоли</summary>
        public static void PrintArray(int[,] array)
        {
            Console.WriteLine("\nRandom array:\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    System.Console.Write($"{array[i, j]}\t");
                }
                System.Console.WriteLine();
            }
        }
        /// <summary>Метод печатает double массив в консоли</summary>
        public static void PrintArray(double[,] array)
        {
            Console.WriteLine("\nRandom array:\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    System.Console.Write($"{array[i, j]}\t");
                }
                System.Console.WriteLine();
            }
        }
        /// <summary>Метод заполняет массив случайными числами от -99 до 100</summary>
        public static int[,] FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(-99, 100);
                }
            }
            return array;
        }
        /// <summary>Метод заполняет массив случайными вещественными числами</summary>
        public static double[,] FillArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Math.Round((new Random().NextSingle()) + (new Random().Next(-99, 100)), 1);
                }
            }
            return array;
        }
        /// <summary>Метод спрашивает размерность массива и создает пустой int массив указанного размера</summary>
        public static int[,] AskSizeIntArray()
        {
            Console.Write("\nEnter number of lines: \t\t");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter number of columns:\t");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[m, n];
            return array;
        }
        /// <summary>Метод спрашивает размерность массива и создает пустой double массив указанного размера</summary>
        public static double[,] AskSizeDoubleArray()
        {
            Console.Write("\nEnter number of lines: \t\t");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter number of columns:\t");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] array = new double[m, n];
            return array;
        }
    }
}