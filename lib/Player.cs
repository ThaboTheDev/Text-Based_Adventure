namespace Text_based_AdventureGame.lib
{
    public class Player(string name, int health, Room room)
    {
        private string Name { get; } = name;
        private int Health { get; set; } = health;
        private List<Item> Inventory { get; set; } = [];
        private Room CurrentRoom { get; set; } = room;

        public void SetRoom(Room newRoom)
        {
            CurrentRoom = newRoom;
        }

        public string? Move(string direction)
        {
            string? exit = CurrentRoom.GetExit(direction);
            if (exit == null)
            {
                Console.WriteLine($"Exit {direction} is not in the room.");
                return null;
            }
            else
            {
                Console.WriteLine("Exit found.");
                return exit;
            }
        }

        public override string ToString()
        {
            return $"Player: {Name}, Health: {Health}, Current Room: {CurrentRoom.Id}";
        }

        public void DescribeCurrentRoom()
        {
            Console.Clear();
            Console.WriteLine($"You are in room: {CurrentRoom.Id}");
            Console.WriteLine(CurrentRoom.Description);
            ShowItems();
            Console.WriteLine();
            ShowEnemies();
            Console.WriteLine();
            ShowExits();
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...>");
            string input = Console.ReadLine()!.Trim();
        }

        private void ShowItems()
        {
            if (CurrentRoom.Items.Count > 0)
            {
                Console.WriteLine("Items in the room:");
                foreach (string item in CurrentRoom.Items)
                {
                    Console.WriteLine($"- {item}");
                }
            }
            else
            {
                Console.WriteLine("No items in the room.");
            }
        }

        private void ShowEnemies()
        {
            if (CurrentRoom.Enemies.Count > 0)
            {
                Console.WriteLine("Enemies in the room:");
                foreach (string enemy in CurrentRoom.Enemies)
                {
                    Console.WriteLine($"- {enemy}");
                }
            }
            else
            {
                Console.WriteLine("No enemies in the room.");
            }
        }

        private void ShowExits()
        {
            Console.WriteLine("Exits:");
            foreach (var exit in CurrentRoom.Exits)
            {
                Console.WriteLine($"- {exit.Key}: {exit.Value}");
            }
        }
    }
}