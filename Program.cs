// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Attack Firega = new Attack("Firega Attack", 30);
Attack Waterga = new Attack("Waterga Attack", 35);
Attack Thunderga = new Attack("Thunderga Attack", 50);

List<Attack> AttackList = new List<Attack>
{
    Firega,
    Waterga,
    Thunderga
};


Enemy Sephiroth = new Enemy("Sephiroth", 100); // <---- <Attrack> has a class inside the <>
// Enemy Sephiroth = new Enemy("Sephiroth", 100, new List<Attack>{Firega}); // <---- <Attrack> has a class inside the <>


Sephiroth.AddToAttackList(Waterga);
Sephiroth.AddToAttackList(Firega);
Sephiroth.AddToAttackList(Thunderga);
Sephiroth.RandomAttack();
