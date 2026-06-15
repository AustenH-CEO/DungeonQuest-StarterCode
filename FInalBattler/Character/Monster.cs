using FinalBattler.Interfaces;

namespace FinalBattler.Character
{
    public class Monster : Creations
    {
        public Monster()
        {
            Name = "Mob";
            Level = 1;
            Health = 1;
            Power = 1;
            Luck = 1;
            MinDamage = 1;
            MaxDamage = 4;
        }
        public Monster(string name, int level, int health, int power, int luck, int maxDamage, int minDamage)
        {
            this.Name = name;
            this.Level = level;
            this.Health = health;
            this.Power = power;
            this.Luck = luck;
            this.MaxDamage = maxDamage;
            this.MinDamage = minDamage;
        }
    }
}
