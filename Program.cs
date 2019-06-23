using System;

namespace RPG_Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new Game().NewGame();
            }
            catch (Exception exception)
            {
                Console.WriteLine("An error occurred: " + exception);
            }
        }
    }
}
