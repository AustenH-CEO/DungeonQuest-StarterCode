using FinalBattler.Character;
using System;
namespace FinalBattler.GamePlay
{
    public static class Combat
    {
        public static void CombatLoop(Hero Fighter1, Hero Fighter2)
        {
            while (Fighter1.IsAlive && Fighter2.IsAlive)
            {
                Fighter1.DealDamage(Fighter2);
                if (Fighter2.IsAlive)
                {
                    Fighter2.DealDamage(Fighter1);
                }
            }
            
        }
    }
}
