
using ConsoleApp8;
using System.ComponentModel;

class Player
{
    public int Hp { get; set; }

    public Player(int health)
    {
        Hp = health;
    }

    public void AttackWithWeapon(Weapon weapon, Opponent opponent)
    {
        Console.WriteLine($"Attacking with {weapon.GetType().Name}. Lethality: {weapon.Lethality}");
        if (opponent.AvoidAttack(weapon.Accuracy))
        {
            Console.WriteLine("Opponent avoided the attack!");
        }
        else
        {
            int damage = weapon.Lethality;
            opponent.TakeDamage(damage);
            Console.WriteLine($"Dealt {damage} damage to the opponent. Opponent's HP: {opponent.Hp}");
        }
    }

    public bool AvoidAttack(int accuracy)
    {
        Random random = new Random();
        int chance = random.Next(1, 101);
        return chance <= accuracy - 30;
    }
}
