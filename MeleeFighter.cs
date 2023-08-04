public class MeleeFighter : Enemy
{
    public MeleeFighter() : base ("Sir Auron", 120)
    {
        AttackList = new List<Attack>();
    }

    public void RandomAttack()
    {
        Random random = new Random();
        Console.WriteLine(AttackList[random.Next(0, AttackList.Count)].AttackName);

    }

    public void AddToAttackList(Attack newAttack)
    {
        AttackList.Add(newAttack);
        
    }
}