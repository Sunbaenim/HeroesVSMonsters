using HeroesVSMonsters.Models.MapTemplate;
using HeroesVSMonsters.Models.CharacterTemplate.Heroes.Abstracts;

namespace HeroesVSMonsters.Models.CharacterTemplate.Heroes.Concrete
{
    public class Dwarf : Hero
    {
        public Dwarf(string charactersName, Map mapName) : base (charactersName, mapName)
        {

        }
    }
}
