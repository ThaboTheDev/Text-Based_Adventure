namespace Text_based_AdventureGame.lib
{
    public class Enemy(string name, int health, int attack)
    {
        public string Name { get; } = name;
        public int Health { get; } = health;
        public int Attack { get; } = attack;
    }
}