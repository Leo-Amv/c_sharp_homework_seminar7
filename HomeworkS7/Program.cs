namespace Homework
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Text.Menu();
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.D1)
                {
                    Text.Task47();
                    Solutions.Task47Sol();
                }
                else if (input.Key == ConsoleKey.D2)
                {
                    Text.Task50();
                    Solutions.Task50Sol();
                }
                else
                {
                    Console.WriteLine("\nPROGRAM IS OVER!\n");
                }
            }
            catch
            {
                Console.WriteLine("\nINCORRECT DATA TRY AGAIN!");
                Main();
            }
        }
    }
}
