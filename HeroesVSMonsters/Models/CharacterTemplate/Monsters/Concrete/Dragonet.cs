﻿using System;
using HeroesVSMonsters.Models.CharacterTemplate.Monsters.Abstracts;
using HeroesVSMonsters.Models.CharacterTemplate.Monsters.Interfaces;

namespace HeroesVSMonsters.Models.CharacterTemplate.Monsters.Concrete
{
    public class Dragonet : Monster, IGold, ILeather
    {
        public ushort QuantityOfGold { get; }
        public ushort QuantityOfLeather { get; }
        public Dragonet()
        {
            QuantityOfGold = base._d6.ThrowDices();
            QuantityOfLeather = base._d4.ThrowDices();
        }
    }
}