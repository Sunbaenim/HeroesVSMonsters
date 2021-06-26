using System;
using HeroesVSMonsters.Models.CharacterTemplate.Monsters.Abstracts;
using HeroesVSMonsters.Models.CharacterTemplate.Monsters.Interfaces;

namespace HeroesVSMonsters.Models.CharacterTemplate.Monsters.Concrete
{
    public class Wolf : Monster, ILeather
    {
        public ushort QuantityOfLeather { get; }
        public Wolf()
        {
            QuantityOfLeather = base._d4.ThrowDices();
        }
    }
}
