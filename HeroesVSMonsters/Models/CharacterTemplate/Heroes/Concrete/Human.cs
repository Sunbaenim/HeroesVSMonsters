using HeroesVSMonsters.Models.MapTemplate;
using HeroesVSMonsters.Models.CharacterTemplate.Heroes.Abstracts;

namespace HeroesVSMonsters.Models.CharacterTemplate.Heroes.Concrete
{
    public class Human : Hero
    {
        public Human(string charactersName, Map mapName) : base (charactersName, mapName)
        {

        }
    }
}
