namespace FinalBattler.Character.Upgrades
{
    public class Equipment
    {
        public string EquipmentName { get; set; } = string.Empty;
        public EquipmentSlot Slot { get; set; }
        public StatBoostType StatBoostType { get; set; }
        public int BoostValue { get; set; }

        public Equipment()
        {
            EquipmentName = string.Empty;
            Slot = EquipmentSlot.none;
            StatBoostType = StatBoostType.none;
            BoostValue = 0;
        }

        public Equipment(string name, EquipmentSlot slot, StatBoostType statBoostType, int boostValue)
        {
            EquipmentName = name;
            Slot = slot;
            StatBoostType = statBoostType;
            BoostValue = boostValue;
        }
    }
    public enum EquipmentSlot
    {
        none,
        Head,
        Chest,
        LeftArm,
        RightArm,
        Legs,
        Boots,
        Cape
    }

    public enum StatBoostType
    {
        none,
        Health,
        Power,
        Luck
    }
}
