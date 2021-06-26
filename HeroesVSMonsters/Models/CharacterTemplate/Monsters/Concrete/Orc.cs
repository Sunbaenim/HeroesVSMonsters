using System;
using HeroesVSMonsters.Models.CharacterTemplate.Monsters.Abstracts;
using HeroesVSMonsters.Models.CharacterTemplate.Monsters.Interfaces;

namespace HeroesVSMonsters.Models.CharacterTemplate.Monsters.Concrete
{
    public class Orc : Monster, IGold
    {
        public ushort QuantityOfGold { get; }
        public Orc()
        {
            QuantityOfGold = base._d6.ThrowDices();
        }
    }
}
