

using FinalBattler.Character;
using FinalBattler.Interfaces;

public class Program
{
    static void Main()
    {
        Creations GoodGuy = new Hero();
        Creations BadGuy = new Monster();
        BadGuy.DealDamage(GoodGuy);

    }
}

