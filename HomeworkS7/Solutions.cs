namespace Homework
{
    class Solutions
    {
        /// <summary>Метод запускает в консоли решение задачи 47</summary>
        public static void Task47Sol()
        {
            double[,] array = Methods.AskSizeDoubleArray();
            Methods.FillArray(array);
            Methods.PrintArray(array);
        }
        /// <summary>Метод запускает в консоли решение задачи 50</summary>
        public static void Task50Sol()
        {
            int[,] array = Methods.AskSizeIntArray();
            Console.Write("\nEnter line position (first line starts with elemnt '0') : \t\t");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter column position (first column starts with elemnt '0') :\t\t");
            int columns = Convert.ToInt32(Console.ReadLine());
            Methods.FillArray(array);
            Methods.PrintArray(array);
            if (rows >= array.GetLength(0) || columns >= array.GetLength(1))
            {
                Console.WriteLine("\nThe element you are looking for does not exist!");
            }
            else
            {
                Console.WriteLine($"\nThe element you are looking for :\t{array[rows, columns]}");
            }
        }
        /// <summary>Метод запускает в консоли решение задачи 52</summary>
        public static void Task52Sol()
        {
            int[,] array = Methods.AskSizeIntArray();
            Methods.FillArray(array);
            Methods.PrintArray(array);
            Console.WriteLine("\nArithmetic mean in columns:\n");
            Methods.ArithMeanColumns(array);
        }
    }
}