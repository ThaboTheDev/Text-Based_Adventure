using System.Text.Json;
using Microsoft.VisualBasic;

namespace Text_based_AdventureGame.lib
{
    public class Game
    {
        private World? World { get; set; }
        private Player? Player { get; set; }
        private Command? Command { get; set; }
        public void Start()
        {
            World = new World();
            Player = new Player("thabo", 10, World.GetStartRoom());
            Command = new Command(World, Player);

            RunGame(Command);
        }

        private void RunGame(Command command)
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine(">");
                    string input = Console.ReadLine()!.Trim();

                    if (input.Equals("exit"))
                    {
                        break;
                    }

                    command.Handlecommand(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
            Console.WriteLine("Goodbye!");
        }
    }
}