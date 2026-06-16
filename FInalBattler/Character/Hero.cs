using FinalBattler.Character.Upgrades;
using FinalBattler.Interfaces;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace FinalBattler.Character
{
    public class Hero : Creations, IHero
    {
        public int TotalMana { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<Spell> Spells { get; set; } = new List<Spell>();
        public List<Equipment> Equipment { get; set; } = new List<Equipment>();

        public Hero()
        {
            this.Name = "Warrior Hero";
            this.CombatClass = CombatClass.Warrior;
            this.Level = 1;
            CalculateTotals(this.Level, this.CombatClass);
            Health = TotalHealth;
            Items.Add(new Item());
        }
        public Hero(string name, CombatClass combatClass)
        {
            this.Name = name;
            this.CombatClass = combatClass;
            this.Level = 1;
            CalculateTotals(Level, CombatClass);
            Health = TotalHealth;
            Mana = TotalMana;
        }
        public void DisplayStats(bool showTotalStats)
        {
            if (showTotalStats == false)
            {
                Console.WriteLine("Health: " + Health + "/" + TotalHealth);
                Console.WriteLine("Power: " + TotalPower + "/" + TotalPower);
                Console.WriteLine("Luck: " + TotalLuck + "/" + TotalLuck);
                Console.WriteLine("Mana: " + Mana);
            }
            else
            {
                Console.WriteLine("Health: " + Health + "/" + TotalHealth);
                Console.WriteLine("Power: " + TotalPower);
                Console.WriteLine("Luck: " + TotalLuck);
                Console.WriteLine("Mana: " + Mana);
                Console.WriteLine("Experience Remaining: " + ExperienceRemaining);
                Console.WriteLine("Class: " + CombatClass.ToString());
                if (Items == null || Items.Count == 0)
                    Console.WriteLine("No items.");
                else
                {
                    Console.WriteLine("Items: ");
                    foreach (Item item in Items)
                    {
                        Console.WriteLine(item.ItemName.ToString());
                    }
                }
                if (Skills == null || Skills.Count == 0)
                    Console.WriteLine("No skills.");
                else
                {
                    Console.WriteLine("Skills: ");
                    foreach (Skill skill in Skills)
                    {
                        Console.WriteLine(skill.ToString());
                    }
                }
                if (Equipment == null || Equipment.Count == 0)
                    Console.WriteLine("No equipment.");
                else
                {
                    Console.WriteLine("Equipment: ");
                    foreach (Equipment equipment in Equipment)
                    {
                        Console.WriteLine(equipment.ToString());
                    }
                }
                if(CombatClass == CombatClass.Wizard)
                {
                    if (Spells == null || Spells.Count == 0)
                        Console.WriteLine("No spells.");
                    else
                    {
                        Console.WriteLine("Spells: ");
                        foreach (Spell spell in Spells)
                        {
                            Console.WriteLine(spell.ToString());
                        }
                    }
                }
            }
        }
        public void LevelUp()
        {
            Console.WriteLine("LEVEL UP! ");
            this.Level += 1;
            int increaseHealth;
            int increasePower;
            int increaseLuck;
            Random random = new Random();
            int randomInt = random.Next();
            switch (CombatClass)
            {
                case (CombatClass) CombatClass.Warrior:
                    increaseHealth = random.Next(10, 20);
                    increasePower = random.Next(1, 3);
                    increaseLuck = random.Next(1, 3);
                    CalculateTotals(Level, CombatClass, increaseHealth, increasePower, increaseLuck);
                    Health = TotalHealth;
                    TotalPower = TotalPower;
                    TotalLuck = TotalLuck;
                    break;
                case (CombatClass) CombatClass.Wizard:
                    increaseHealth = random.Next(1, 15);
                    increasePower = random.Next(3, 5);
                    increaseLuck = random.Next(1, 3);
                    CalculateTotals(Level, CombatClass, increaseHealth, increasePower, increaseLuck);
                    Health = TotalHealth;
                    TotalPower = TotalPower;
                    TotalLuck = TotalLuck;
                    TotalMana += 10;
                    Mana = TotalMana;
                    break;
                case (CombatClass) CombatClass.Rogue:
                    increaseHealth = random.Next(1, 15);
                    increasePower = random.Next(1, 3);
                    increaseLuck = random.Next(3, 5);
                    CalculateTotals(Level, CombatClass, increaseHealth, increasePower, increaseLuck);
                    Health = TotalHealth;
                    TotalPower = TotalPower;
                    TotalLuck = TotalLuck;
                    break;
            }
            
        }
        public void CalculateTotals(int level, CombatClass combatClass)
        {
            if (combatClass == CombatClass.Warrior)
            {
                this.TotalHealth = 30;
                this.TotalPower = 5;
                this.TotalLuck = 2;
                this.MinDamage = TotalPower;
                this.MaxDamage = MinDamage + TotalPower;
            }
            else if (combatClass == CombatClass.Wizard)
            {
                this.TotalHealth = 18;
                this.TotalPower = 4;
                this.TotalLuck = 2;
                this.TotalMana = 100;
                this.MinDamage = TotalPower;
                this.MaxDamage = MinDamage + TotalPower;
            }
            else if (combatClass == CombatClass.Rogue)
            {
                this.TotalHealth = 20;
                this.TotalPower = 2;
                this.TotalLuck = 4;
                this.MinDamage = TotalPower;
                this.MaxDamage = MinDamage + TotalPower;
            }
        }
        public void CalculateTotals(int level, CombatClass combatClass, int health, int power, int luck)
        {
            if (combatClass == CombatClass.Warrior)
            {
                this.TotalHealth = health + (level * 10);
                this.TotalPower = power + (level * 2);
                this.TotalLuck = luck + (level * 2);
            }
            else if (combatClass == CombatClass.Wizard)
            {
                this.TotalHealth = health + (level * 5);
                this.TotalPower = power + (level * 4);
                this.TotalLuck = luck + (level * 2);
                this.TotalMana = 100 + (level * 5);
            }
            else if (combatClass == CombatClass.Rogue)
            {
                this.TotalHealth = health + (level * 5);
                this.TotalPower = power + (level * 2);
                this.TotalLuck = luck + (level * 4);
            }
        }
    }
}
