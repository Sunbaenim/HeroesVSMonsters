using HeroesVSMonsters.Models.MapTemplate;
using HeroesVSMonsters.Models.CharacterTemplate.Monsters.Abstracts;
using HeroesVSMonsters.Models.CharacterTemplate.Interfaces;

namespace HeroesVSMonsters.Models.CharacterTemplate.Monsters.Concrete
{
    public class Wolf : Monster, ILeather
    {
        public ushort QuantityOfLeather { get; }
        public Wolf(string charactersName, Map mapName) : base (charactersName, mapName)
        {
            QuantityOfLeather = base._d4.ThrowDices();
        }
    }
}
