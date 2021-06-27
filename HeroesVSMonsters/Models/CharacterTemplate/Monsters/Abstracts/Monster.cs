using HeroesVSMonsters.Models.MapTemplate;
using HeroesVSMonsters.Models.CharacterTemplate.Abstracts;

namespace HeroesVSMonsters.Models.CharacterTemplate.Monsters.Abstracts
{
    public abstract class Monster : Character
    {
        public Monster(string charactersName, Map mapName) : base (charactersName, mapName)
        {

        }
        public override void Strike(Character target)
        {
            base.Strike(target);
            if (target.HealthPoints <= 0)
            {
                MapName.CharactersList.Remove(target);
            }
        }
    }
}
