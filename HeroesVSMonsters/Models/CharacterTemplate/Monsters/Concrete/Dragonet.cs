using HeroesVSMonsters.Models.MapTemplate;
using HeroesVSMonsters.Models.CharacterTemplate.Monsters.Abstracts;
using HeroesVSMonsters.Models.CharacterTemplate.Interfaces;

namespace HeroesVSMonsters.Models.CharacterTemplate.Monsters.Concrete
{
    public class Dragonet : Monster, IGold, ILeather
    {
        public ushort QuantityOfGold { get; }
        public ushort QuantityOfLeather { get; }
        public Dragonet(string charactersName, Map mapName ) : base(charactersName, mapName)
        {
            QuantityOfGold = base._d6.ThrowDices();
            QuantityOfLeather = base._d4.ThrowDices();
        }
    }
}
