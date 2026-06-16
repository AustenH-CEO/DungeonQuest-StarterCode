using FinalBattler.Character;

namespace FinalBattler.Interfaces
{
    public interface IHero
    {
        void DisplayStats(bool showTotalStats = false);
        void LevelUp();
        void CalculateTotals(int level, CombatClass combatClass);
    }
}
