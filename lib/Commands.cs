namespace Text_based_AdventureGame.lib
{
    public class Command(World world, Player player)
    {
        private World World1 { get; set; } = world;
        private Player Player1 { get; set; } = player;

        public void Handlecommand(string input)
        {
            string[] command = input.Split(" ");
            switch (command[0])
            {
                case "go":
                    string? newRoomId = Player1.Move(command[1]);
                    if (newRoomId == null)
                    {
                        Console.WriteLine($"Failed to me {command[1]}");
                    }
                    else
                    {
                        Room newRoom = World1.GetRoomById(newRoomId)!;
                        Player1.SetRoom(newRoom);
                        Console.WriteLine($"You moved to {newRoom.Id}");
                    }
                    break;

                case "look":
                    Player1.DescribeCurrentRoom();
                    break;

                default:
                    Console.WriteLine($"Invalid input: {command[0]}");
                    break;
            }
        }
    }
}