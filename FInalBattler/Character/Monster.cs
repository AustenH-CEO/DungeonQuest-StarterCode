using FinalBattler.Interfaces;

namespace FinalBattler.Character
{
    public class Monster : Creations
    {
        public CombatClass CombatClass { get; set; }
        public Monster()
        {
            Name = "Mob";
            Level = 1;
            Health = 1;
            TotalPower = 1;
            TotalLuck = 1;
            MinDamage = 1;
            MaxDamage = 4;
            CombatClass = CombatClass.None;
        }
        public Monster(string name, int level, int health, int power, int luck, int maxDamage, int minDamage)
        {
            this.Name = name;
            this.Level = level;
            this.Health = health;
            this.TotalPower = power;
            this.TotalLuck = luck;
            this.MaxDamage = maxDamage;
            this.MinDamage = minDamage;
            CombatClass = CombatClass.None;
        }
    }
}
