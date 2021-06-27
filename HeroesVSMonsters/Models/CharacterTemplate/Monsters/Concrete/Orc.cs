using HeroesVSMonsters.Models.MapTemplate;
using HeroesVSMonsters.Models.CharacterTemplate.Monsters.Abstracts;
using HeroesVSMonsters.Models.CharacterTemplate.Interfaces;

namespace HeroesVSMonsters.Models.CharacterTemplate.Monsters.Concrete
{
    public class Orc : Monster, IGold
    {
        public ushort QuantityOfGold { get; }
        public Orc(string charactersName, Map mapName) : base (charactersName, mapName)
        {
            QuantityOfGold = base._d6.ThrowDices();
        }
    }
}
