public class Enemy
{
    public string Name;
    public int Health;
    public List<Attack> AttackList;

    // public Enemy(string name, int health, List<Attack> attackList){
    public Enemy(string name, int health){
        Name = name;
        Health = health;
        AttackList = new List<Attack>();

    }

    public void RandomAttack()
    {
        Random random = new Random();
        Console.WriteLine(AttackList[random.Next(0, AttackList.Count)].AttackName);

    }

    public void AddToAttackList(Attack newAttack )
    {
        AttackList.Add(newAttack);

    }


    // Inside of the Enemy class
public void PerformAttack(Enemy Target, Attack ChosenAttack)
{
    // Write some logic here to reduce the Targets health by your Attack's DamageAmount
    Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
}


}