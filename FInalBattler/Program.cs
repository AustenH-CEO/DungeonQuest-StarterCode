using FinalBattler.GamePlay;
using FinalBattler.Character;
using FinalBattler.Interfaces;
public class Program
{
    static void Main()
    { 
        Hero Hero = new Hero("George", CombatClass.Wizard);
        Hero Enemy = new Hero("Evil George", CombatClass.Rogue);
        Hero.DisplayStats(true);
        Combat.CombatLoop(Hero, Enemy);
    }
}
