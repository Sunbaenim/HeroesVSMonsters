using HeroesVSMonsters.Models.CharacterTemplate.Interfaces;

namespace HeroesVSMonsters.Models.CharacterTemplate.Heroes.InventoryTemplate
{
    public class Inventory
    {
        public Inventory()
        {
            this.SlotGold = new SlotInventary<IGold>();
            this.SlotLeather = new SlotInventary<ILeather>();
        }
        public SlotInventary<IGold> SlotGold { get; }
        public SlotInventary<ILeather> SlotLeather { get; }
    }
}
