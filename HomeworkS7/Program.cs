namespace Homework
{
    class Program
    {
        public static void Main(string[] args)
        {
            Text.Menu();
            ConsoleKeyInfo input = Console.ReadKey();
            if (input.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Text.Task47();
                Solutions.Task47Sol();
            }
        }
    }
}
