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

    // public virtual void PrintMessage(){
    //     Console.WriteLine("Message from the base/parent class...");
    // }

    // public Enemy(string name, int health, List<Attack> attackList){
    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
        AttackList = new List<Attack>();

    }

    public virtual void RandomAttack(Enemy target)
    {
        Random random = new Random();
        int randomNum = random.Next(0, AttackList.Count);
        Console.WriteLine(AttackList[randomNum].AttackName);
        PerformAttack(target, AttackList[randomNum]);
    }

    public void AddToAttackList(Attack newAttack)
    {
        AttackList.Add(newAttack);
        
    }

    public void ReduceHealth(int damage){
        Health -= damage;
    }

    public void RegainHealth(int hp){
        Health += hp;
    }

    // Inside of the Enemy class
    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        // Write some logic here to reduce the Targets health by your Attack's DamageAmount

        Target.Health -= ChosenAttack.DamageAmount; // "-=" is the Subtract AND assignment operator. It subtracts right operand from the left operand and assign the result to left operand.


        Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }


    public virtual void ShowHealth()
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