using System;
using HeroesVSMonsters.Models.CharacterTemplate.Abstracts;

namespace HeroesVSMonsters.Models.CharacterTemplate.Monsters.Abstracts
{
    public abstract class Monster : Character
    {
        public override void Strike(Character target)
        {
            base.Strike(target);
            if (target.HealthPoints <= 0)
            {
                base.CharactersList.Remove(this);
            }
        }
    }
}
