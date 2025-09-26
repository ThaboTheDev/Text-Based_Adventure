using System.Dynamic;

namespace Text_based_AdventureGame.lib
{
    public class Room(string id, string description, Dictionary<string, string> exits, List<string> items, List<string> enemies)
    {
        public string Id { get; } = id;
        public string Description { get; } = description;
        public Dictionary<string, string> Exits { get; } = exits;
        public List<string> Items { get; set; } = items;
        public List<string> Enemies { get; } = enemies;

        public string? GetExit(string direction)
        {
            List<string> validDirectons = ["north", "south", "east", "west"];
            if (validDirectons.Contains(direction))
            {
                return Exits[direction];
            }
            return null;
        }
    }
}