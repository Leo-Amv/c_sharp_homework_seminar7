namespace Homework
{
    public class Methods
    {
        /// <summary>Метод печатает int массив в консоли</summary>
        public static void PrintArray(int[,] array)
        {
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
    }
}