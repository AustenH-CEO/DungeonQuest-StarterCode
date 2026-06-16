using FinalBattler.Character.Upgrades;
using FinalBattler.Interfaces;
using FinalBattler.Utilities;
using System.Reflection;

namespace FinalBattler.Character
{
    public abstract class Creations : IDamageCalculator
    {
        //Moved name, health, power, luck, and damage properties to Creations to deduce duplicate code.
        public bool IsAlive { get; set; } = true;
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
        public int TotalHealth { get; set; }
        public int Health { get; set; }
        public int TotalPower { get; set; }
        public int TotalLuck { get; set; }
        public void DealDamage(Creations Creature)
        {
            Console.WriteLine(this.Name + " is attacking " + Creature.Name);
            Random rnd = new Random();
            int Damage = rnd.Next(this.MinDamage, this.MaxDamage);
            Damage += (this.Level + this.TotalPower);
            Console.WriteLine("Damage: -" + Damage);
            Creature.Health -= Damage;
            if (Creature.Health <= 0)
            {
                Creature.IsAlive = false;
                Creature.Health = 0;
                Console.WriteLine(Creature.Name + " has been defeated!");
            }
            Console.WriteLine(Creature.Name + "'s Health: " + Creature.Health);
            Utility.Separate();
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
