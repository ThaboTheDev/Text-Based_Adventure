using System.Text.Json;

namespace Text_based_AdventureGame.lib
{
    public class World
    {
        private List<Room> Rooms { get; set; } = [];
        private List<Item> Items { get; set; } = [];
        private List<Enemy> Enemies { get; set; } = [];

        public World()
        {
            LoadData("assets/map.json");
            LoadData("assets/items.json");
            LoadData("assets/enemies.json");
        }

        public Item? GetItem(string itemName)
        {
            foreach (Item item in Items)
            {
                if (itemName.Equals(item.Name))
                {
                    return item;
                }
            }
            return null;
        }

        public Room? GetRoomById(string roomId)
        {
            foreach (Room room in Rooms)
            {
                if (room.Id == roomId)
                {
                    return room;
                }
            }

            return null;
        }

        public Room GetStartRoom()
        {
            return Rooms[0];
        }

        private void LoadData(string fileName)
        {
            try
            {
                var data = File.ReadAllText(fileName);

                switch (fileName)
                {
                    case "assets/enemies.json":
                        Enemies = JsonSerializer.Deserialize<List<Enemy>>(data)!;
                        break;

                    case "assets/items.json":
                        Items = JsonSerializer.Deserialize<List<Item>>(data)!;
                        break;

                    case "assets/map.json":
                        Rooms = JsonSerializer.Deserialize<List<Room>>(data)!;
                        break;

                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}