namespace Homework
{
    class Solutions
    {
        /// <summary>Метод запускает в консоли решение задачи 47</summary>
        public static void Task47Sol()
        {
            Console.Write("\nEnter number of lines: \t\t");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter number of columns:\t");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] array = new double[m, n];
            Methods.FillArray(array);
            Console.WriteLine("\nRandom array:\n");
            Methods.PrintArray(array);
        }
        /// <summary>Метод запускает в консоли решение задачи 50</summary>

    }
}