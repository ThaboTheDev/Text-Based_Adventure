namespace Text_based_AdventureGame.lib
{
    public class Item(string name, string type, Dictionary<string, int>? effects)
    {
        public string Name { get; } = name;
        public string Type { get; } = type;
        public Dictionary<string, int>? Effects { get; } = effects;
    }
}