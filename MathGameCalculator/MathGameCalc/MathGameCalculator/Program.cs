namespace MathGameCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //clears the command console.
            bool shouldExit = false;

            GameStart.StartScreen();
            while (!shouldExit)
            {
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    shouldExit = true;
            }

        }
    }
}
