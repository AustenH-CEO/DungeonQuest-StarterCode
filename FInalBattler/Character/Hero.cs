using FinalBattler.Character.Upgrades;
using FinalBattler.Interfaces;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace FinalBattler.Character
{
    public class Hero : Creations, IHero
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Equipment> Equipment { get; set; }

        public Hero()
        {
            Name = "Unknown";
            Level = 0;
            Health = 1;
            Power = 1;
            Luck = 1;
            Mana = 1;
        }
        public void DisplayStats(bool showTotalStats = false)
        {
            Console.WriteLine("Health: " + Health + "/" + TotalHealth);
            Console.WriteLine("Power: " + Power + "/" + TotalPower);
            Console.WriteLine("Luck: " + Luck + "/" + TotalLuck);
            Console.WriteLine("Mana: " + Mana);
        }
        public void DisplayStats()
        {
            Console.WriteLine("Health: " + Health + "/" + TotalHealth);
            Console.WriteLine("Power: " + Power + "/" + TotalPower);
            Console.WriteLine("Luck: " + Luck + "/" + TotalLuck);
            Console.WriteLine("Mana: " + Mana);
            Console.WriteLine("Experience Remaining: " + ExperienceRemaining);
            Console.WriteLine("Class: " + CombatClass.ToString());
            Console.WriteLine("Items: ");
            foreach (Item item in Items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Skills: ");
            foreach (Skill skill in Skills)
            {
                Console.WriteLine(skill.ToString());
            }
            Console.WriteLine("Equipment: ");
            foreach (Equipment equipment in Equipment)
            {
                Console.WriteLine(equipment.ToString());
            }
        }
        public void LevelUp()
        {
            Random random = new Random();
            int randomInt = random.Next();
            switch (CombatClass)
            {
                case (CombatClass)1:
                    Health += random.Next(10, 20);
                    Power += random.Next(1, 3);
                    Luck += random.Next(1, 3);
                    break;
                case (CombatClass)2:
                    Health += random.Next(1, 15);
                    Power += random.Next(3, 5);
                    Luck += random.Next(1, 3);
                    break;
                case (CombatClass)3:
                    Health += random.Next(1, 15);
                    Power += random.Next(1, 3);
                    Luck += random.Next(3, 5);
                    break;
            }
            
        }
        public void CalculateTotals()
        {

        }
    }
}
