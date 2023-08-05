using System.Net.Http.Headers;
using System.Runtime.Versioning;

public class MeleeFighter : Enemy
{
    public MeleeFighter(string Name) : base(Name, 120)
    {
        AttackList = new List<Attack>()
        {
        new Attack("Punch", 20), //<--- Need commas for dicts and lists
        new Attack("Kick", 15),
        new Attack("Tackle", 25),

        };
    }
    //  public override void PrintMessage(){
    //     Console.WriteLine("Message from the inhereted/child class...");
    // }

    public void Rage(Enemy target){

        int RageValue = 10;
        Console.WriteLine("Rage fell apon thy enemy...");
        target.ReduceHealth(RageValue);
        RandomAttack(target);

    }
}