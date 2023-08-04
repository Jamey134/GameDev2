using System.Reflection.Metadata.Ecma335;

public class Enemy
{
    public string Name;
    private int Health; // <-- potential black belt feature (BONUS)
    public int _Health{
        get
        {
            return Health;    
        }
        set
        {
            Console.WriteLine(_Health);
            Health = _Health;
        }}
    public List<Attack> AttackList;

    // public Enemy(string name, int health, List<Attack> attackList){
    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
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


    // Inside of the Enemy class
    public void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        // Write some logic here to reduce the Targets health by your Attack's DamageAmount

        Target.Health -= ChosenAttack.DamageAmount; // "-=" is the Subtract AND assignment operator. It subtracts right operand from the left operand and assign the result to left operand.


        // Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }


    public void ShowHealth()
    {
        if (Health > 0)
        {
            Console.WriteLine($"{Name} is at {Health}% health!");
        }

        else
        {
            Console.WriteLine("GAME OVER");
        }
    }

}