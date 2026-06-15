using FinalBattler.Interfaces;
using System.Reflection;

namespace FinalBattler.Character
{
    public class Creations : IDamageCalculator
    {
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
        public int TotalHealth { get; set; }
        public int Health { get; set; }
        public int TotalPower { get; set; }
        public int Power { get; set; }
        public int TotalLuck { get; set; }
        public int Luck { get; set; }
        public void DealDamage(Creations Creature)
        {
            Random rnd = new Random();
            int Damage = rnd.Next(this.MinDamage, this.MaxDamage);
            Console.WriteLine("Min: " + this.MinDamage + " Max: " + this.MaxDamage + " Damage: " + Damage);
            Damage *= (this.Level + this.Power);
            Console.WriteLine("dmg: " + Damage);
            Creature.Health -= Damage;
            Console.WriteLine(Creature.Name + "'s Health: " + Creature.Health);
        }
    }

    public enum CombatClass
    {
        None,
        Warrior,
        Wizard,
        Rogue
    }
}
