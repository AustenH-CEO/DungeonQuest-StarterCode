namespace FinalBattler.Character.Upgrades
{
    public class Item
    {
        public string ItemName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ItemPower { get; set; }

        public Item()
        {
            ItemName = "No Items.";
            Description = "No Description.";
            ItemPower = 0;
        }

        public Item(string name, string description)
        {
            ItemName = name;
            Description = description;
        }
    }
}
