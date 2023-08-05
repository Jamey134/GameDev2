public class MagicCaster : Enemy
{
    public MagicCaster(string Name) : base(Name, 80)
    {
        AttackList = new List<Attack>()
        {
        new Attack("Fireball", 25), //<--- Need commas for dicts and lists
        new Attack("Lightening Bolt", 15),
        new Attack("Staff Strike", 10),
        };
    }

    public void Heal(Enemy target)
    {
        int HealSpell = 40;
        Console.WriteLine("Guided light shall norish thee...");
        target.RegainHealth(HealSpell);
        Console.WriteLine($"{target.Name}'s health is at {target._Health}" );
    }
}
