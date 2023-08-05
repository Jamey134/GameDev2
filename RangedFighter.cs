using System.ComponentModel;

public class RangedFighter : Enemy
{
    public int Distance;
    public RangedFighter(string Name) : base(Name, 120)
    {
        Distance = 5;

        AttackList = new List<Attack>()
        {
        new Attack("Arrow Shot", 20), //<--- Need commas for dicts and lists
        new Attack("Knife Throw", 15),
        };
    }


    public void Dash()
    {
        Distance += 20;
        Console.WriteLine($"{Name} has a distance of {Distance}!");

    }

    public void Attack(Enemy target)
    {
        if (Distance > 5)
        {
            RandomAttack(target);
        }
        else
        {
            Console.WriteLine($"{Name} is not close enough to attack!");
        }
    }
}