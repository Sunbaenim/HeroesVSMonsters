using HeroesVSMonsters.Models.MapTemplate;
using HeroesVSMonsters.Models.CharacterTemplate.Abstracts;
using HeroesVSMonsters.Models.CharacterTemplate.Monsters.Concrete;
using HeroesVSMonsters.Models.CharacterTemplate.Heroes.InventoryTemplate;

namespace HeroesVSMonsters.Models.CharacterTemplate.Heroes.Abstracts
{
    public abstract class Hero : Character
    {
        public Inventory _inventory;
        public Hero(string charactersName, Map mapName) : base(charactersName, mapName)
        {
            _inventory = new Inventory();
        }
        public void LootingCorpse(Character monster)
        {
            switch (monster)
            {
                case Dragonet dragonet:
                    _inventory.SlotGold.Quantity += dragonet.QuantityOfGold;
                    _inventory.SlotLeather.Quantity += dragonet.QuantityOfLeather;
                    break;
                case Orc orc:
                    _inventory.SlotGold.Quantity += orc.QuantityOfGold;
                    break;
                case Wolf wolf:
                    _inventory.SlotGold.Quantity += wolf.QuantityOfLeather;
                    break;
                default:
                    break;
            }
        }
        public override void Strike(Character target)
        {
            base.Strike(target);
            if (target.HealthPoints <= 0)
            {
                LootingCorpse(target);
                MapName.CharactersList.Remove(target);
            }
        }
    }
}
