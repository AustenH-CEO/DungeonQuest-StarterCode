using FinalBattler.GamePlay;
using FinalBattler.Character;
using FinalBattler.Interfaces;
using FinalBattler.Character.Upgrades;
public class Program
{
    static void Main()
    {
        Hero George = new Hero("George", CombatClass.Wizard);
        Item HealingPotion = new Item { ItemName = "Healing Potion", Description = "Restores 10 health points.", ItemPower = 10 };
        George.Items.Add(HealingPotion);
        Hero Enemy = new Hero("Evil George", CombatClass.Rogue);
        George.DisplayStats(true);
        Combat.CombatLoop(George, Enemy);
        George.ConsumeItem(George, HealingPotion);
        George.DisplayStats(true);
    }
}
